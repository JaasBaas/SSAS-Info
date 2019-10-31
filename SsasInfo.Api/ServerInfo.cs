using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices;

namespace SsasInfo.Api
{
    public class ServerInfo
    {
        internal Server _server;
        private string _connStr { get { return $"Provider=MSOLAP;Data Source={DataSourceId}"; } }
        public List<DatabaseInfoNew> Databases { get; internal set; } = new List<DatabaseInfoNew>();

        public ServerInfo()
        {
        }

        public string DataSourceId { get; set; }

        public void Connect()
        {
            if (_server == null)
            {
                _server = new Server();
                _server.Connect(_connStr);
            }

        }

        /// <summary>
        /// Gets an indication whether there is a connection to an instance of Analysis Services.
        /// </summary>
        public bool Connected => _server == null ? false : _server.Connected;

        public string DisplayText
        {
            get
            {

                return _server.ID;
            }
        }

        public void ReloadDatabases()
        {
            Databases.Clear();
            foreach (Database db in _server.Databases)
                Databases.Add(new DatabaseInfoNew(this, db));
        }
    }
}
