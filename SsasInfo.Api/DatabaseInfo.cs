using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices;

namespace SsasInfo.Api
{
    public class DatabaseInfoNew
    {
        internal Database Database;
        internal ServerInfo Server;


        public DatabaseInfoNew(ServerInfo server, Database database)
        {
            Server = server;
            Database = database;
        }

        public string Display
        {
            get
            {
                return Database.ID;
            }
        }
    }
}
