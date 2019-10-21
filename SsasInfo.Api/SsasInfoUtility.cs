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
            catch (Exception ex)
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
                        Id = d.ID,
                        Name = d.Name,
                        State = d.State.ToString(),
                        LastProcessed = d.LastProcessed
                    }).ToList();
        }
    }
}
