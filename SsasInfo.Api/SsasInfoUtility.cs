using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices;

namespace SsasInfo.Api
{
    public class SsasInfoUtility
    {
        public string DataSource { get; set; }
        public string Catalog { get; set; }

        private Server _server;


        public bool TestConnectivity()
        {
            try
            {
                var str = $"Provider=MSOLAP;Data Source={DataSource}";

                _server = new Server();
                _server.Connect(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string[] GetDatabases()
        {
            return (from Database e in _server.Databases
                    select e.Name).ToArray();
        }

        public string[] GetCubeNames(string database)
        {
            return (from Cube e in _server.Databases[database].Cubes
                    orderby e.Name
                    select e.Name
                    ).ToArray();
        }


        public List<DimensionInfo> GetDimensionInfo(string database)
        {
            var db = _server.Databases[database];

            return (from Dimension d in db.Dimensions
                    orderby d.Name
                    select new DimensionInfo()
                    {
                        DatabaseId = db.ID,
                        DatabaseName = db.Name,
                        Id = d.ID,
                        Name = d.Name,
                        State = d.State.ToString(),
                        LastProcessed = d.LastProcessed
                    }).ToList();
        }
        public List<PartitionInfo> GetPartitionInfo(string database)
        {

            _server.Refresh(true);

            var db = _server.Databases[database];
            
            return (from Cube c in db.Cubes
                    from MeasureGroup mg in c.MeasureGroups
                    from Partition p in mg.Partitions
                    orderby c.Name, mg.Name, p.Name
                    select new PartitionInfo()
                    {
                        DatabaseId = db.ID,
                        DatabaseName = db.Name,
                        CubeId = c.ID,
                        CubeName = c.Name,
                        Id = p.ID,
                        Name = mg.Name,
                        State = p.State.ToString(),
                        LastProcessed = p.LastProcessed,
                        MeasureGroupName = mg.Name,
                        MeasureGroupId = mg.ID
                    }).ToList();
        }

        public void ProcessDimensions(List<DimensionInfo> dimensions, ProcessType processType)
        {
            foreach (var d in dimensions.Where(d => d.Selected == true))
            {
                var ptid = (int)processType;
                var mspt = (Microsoft.AnalysisServices.ProcessType)ptid;
                d.ProcessStart = DateTime.Now;
                _server.Databases[d.DatabaseId].Dimensions[d.Id].Process(mspt);
                d.ProcessEnd = DateTime.Now;
            }
        }

        #region Partition Processing
        #region Partition Process Event Handling
        public delegate void PartitionProcessUpdateHandler(object sender, PartitionInfo partitionInfo);
        public event PartitionProcessUpdateHandler OnPartitionProcessUpdate;
        private void NotifyPartitionProcessUpdate(PartitionInfo partitionInfo)
        {
            OnPartitionProcessUpdate?.Invoke(this, partitionInfo);
        }
        #endregion

        public void ProcessSelectedPartitions(List<PartitionInfo> partitions, ProcessType processType)
        {
            foreach (var d in partitions.Where(d => d.Selected == true))
            {
                ProcessPartition(d, processType);
            }
        }

        public void ProcessPartition(PartitionInfo partition, ProcessType processType)
        {
            try
            {
                var ptid = (int)processType;
                var mspt = (Microsoft.AnalysisServices.ProcessType)ptid;

                partition.Processing = true;
                partition.ProcessStart = DateTime.Now;
                _server.Databases[partition.DatabaseId].Cubes[partition.CubeId].MeasureGroups[partition.MeasureGroupId].Partitions[partition.Id].Process(mspt);
                partition.ProcessEnd = DateTime.Now;
                partition.Processing = false;
                partition.ProcessSuccessfull = true;

                partition.Selected = false;

                NotifyPartitionProcessUpdate(partition);
            }
            catch (Exception ex)
            {
                partition.ProcessEnd = DateTime.Now;
                partition.Processing = false;
                partition.ProcessSuccessfull = false;
                partition.ProcessError = ex.ToString();

                NotifyPartitionProcessUpdate(partition);
            }
        }
        #endregion
    }
}
