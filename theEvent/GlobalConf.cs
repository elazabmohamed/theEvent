using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theEvent.DataAccess;

namespace theEvent.Models
{
    public static class GlobalConf
    {

        /// <summary>
        ///  An easy way if you want to use more than one database, or switching between two for example, 
        ///  would only need to modify the following code in the if statment and also a little thing in the scope itself
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnection(bool database)
        {
            if (database)
            {
                // set up sqlite connector
                SqliteConnector sql = new SqliteConnector();
               Connections.Add(sql); 

            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;

        }
    }

}
