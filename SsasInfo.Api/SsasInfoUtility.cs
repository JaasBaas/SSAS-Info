using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AnalysisServices;

namespace SsasInfo.Api
{
    public class SsasInfoUtility
    {
        #region Server
        public ServerInfo AddServer(string serverId)
        {
            try
            {
                var server = new ServerInfo();
                server.DataSourceId = serverId;
                server.Connect();

                if (server.Connected)
                {
                    return server;
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Database
        public List<DatabaseInfoNew> GetDatabases(ServerInfo server)
        {
            return (from Database e in server.Databases
                    select new DatabaseInfoNew(server, e)).ToList();
        }
        #endregion

        #region Cube

        #endregion

        #region Dimensions
        public List<DimensionInfo> GetDimensionInfo(DatabaseInfoNew database)
        {
            var db = database.Database;

            return (from Dimension d in db.Dimensions
                    orderby d.Name
                    select new DimensionInfo()
                    {
                        DimensionInternal = d,
                        DatabaseId = db.ID,
                        DatabaseName = db.Name,
                        Id = d.ID,
                        Name = d.Name,
                        State = d.State.ToString(),
                        LastProcessed = d.LastProcessed
                    }).ToList();
        }


        public void ProcessDimensions(List<DimensionInfo> dimensions, ProcessType processType)
        {
            foreach (var d in dimensions.Where(d => d.Selected == true))
            {
                var ptid = (int)processType;
                var mspt = (Microsoft.AnalysisServices.ProcessType)ptid;
                d.ProcessStart = DateTime.Now;
                d.DimensionInternal.Process(mspt);
                d.ProcessEnd = DateTime.Now;
            }
        }
        #endregion

        #region Partitions
        /// <summary>
        /// Refresh the partitions for a specific database
        /// </summary>
        public List<PartitionInfo> GetPartitionInfo(DatabaseInfoNew database)
        {
            database.Database.Refresh(true);

            return (from Cube c in database.Database.Cubes
                    from MeasureGroup mg in c.MeasureGroups
                    from Partition p in mg.Partitions
                    orderby c.Name, mg.Name, p.Name
                    select new PartitionInfo()
                    {
                        DatabaseInternal = database,
                        PartitionInternal = p
                    }).ToList();
        }

        public void EnablePartitions(List<PartitionInfo> partitions)
        {
            foreach (var p in partitions)
            {
                if (p.QueryDefinition.ToUpper().Contains("AND 1 = 0"))
                {
                    p.QueryDefinition = p.QueryDefinition.ToUpper().Replace("AND 1 = 0", "");
                    p.PartitionInternal.Process(Microsoft.AnalysisServices.ProcessType.ProcessClear);
                    p.NotifyProcessPropertiesChanged();
                }
            }
        }
        #endregion



        #region Partition Processing
        #region Partition Process Event Handling
        public delegate void PartitionProcessUpdateHandler(object sender, PartitionInfo partitionInfo);
        public event PartitionProcessUpdateHandler OnPartitionProcessUpdate;
        private void NotifyPartitionProcessUpdate(PartitionInfo partitionInfo)
        {
            OnPartitionProcessUpdate?.Invoke(this, partitionInfo);
        }
        #endregion

        public void ProcessSelectedPartitions(List<PartitionInfo> partitions, ProcessType processType, int maxThreads)
        {
//            int maxThreads = 2;

            // Create a scheduler that uses x threads. 
            var lcts = new LimitedConcurrencyLevelTaskScheduler(maxThreads);
            List<Task> tasks = new List<Task>();

            // Create a TaskFactory and pass it our custom scheduler. 
            var factory = new TaskFactory(lcts);
            var cts = new CancellationTokenSource();

            // Use our factory to run a set of tasks. 
            //Object lockObj = new Object();
            //int outputItem = 0;

            foreach (var d in partitions.Where(d => d.Selected == true))
            {
                var cp = d;
                var t = factory.StartNew(() => { cp.Process(processType); }, cts.Token);
                tasks.Add(t);
            }

            Task.WaitAll(tasks.ToArray());
            cts.Dispose();

            /*
            var ts = new TaskScheduler();
            ts.MaximumConcurrencyLevel = 3;

            var options = new ParallelOptions
            {
                MaxDegreeOfParallelism = maxThreads
            };

            var p = partitions.Where(v => v.Selected == true).ToList();

            Parallel.ForEach(p,options, currentPartition =>
            {
                currentPartition.Process(processType);
            });
*/
            //foreach (var d in partitions.Where(d => d.Selected == true))
            //{
            //    //ProcessPartition(d, processType);
            //    d.Process(processType);
            //}
        }

        //public void ProcessPartition(PartitionInfo partition, ProcessType processType)
        //{
        //    try
        //    {
        //        var ptid = (int)processType;
        //        var mspt = (Microsoft.AnalysisServices.ProcessType)ptid;

        //        partition.Processing = true;
        //        partition.ProcessStart = DateTime.Now;
        //        partition.PartitionInternal.Process(mspt);
        //        partition.ProcessEnd = DateTime.Now;
        //        partition.Processing = false;
        //        partition.ProcessSuccessfull = true;

        //        partition.Selected = false;

        //        partition.PartitionInternal.Refresh();
        //        partition.NotifyProcessPropertiesChanged();

        //        NotifyPartitionProcessUpdate(partition);
        //    }
        //    catch (Exception ex)
        //    {
        //        partition.ProcessEnd = DateTime.Now;
        //        partition.Processing = false;
        //        partition.ProcessSuccessfull = false;
        //        partition.ProcessError = ex.ToString();

        //        NotifyPartitionProcessUpdate(partition);
        //    }
        //}
        #endregion
    }
}
