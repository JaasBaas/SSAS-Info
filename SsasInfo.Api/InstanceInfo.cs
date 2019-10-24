using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices;

namespace SsasInfo.Api
{
    public class InstanceInfo
    {
        private Server _server;
        private string _connStr { get { return $"Provider=MSOLAP;Data Source={DataSourceId}"; } }

        public InstanceInfo()
        {
        }

        public string DataSourceId { get; set; }

        public void Refresh()
        {
            if (_server == null)
            {
                _server = new Server();
                _server.Connect(_connStr);
            }
        }

        public bool Connected { get { return _server.Connected; } }

    }
}
