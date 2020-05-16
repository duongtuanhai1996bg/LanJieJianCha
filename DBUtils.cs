using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"10.8.145.152";

            //string database = "WebOnlineCode";
            string username = "o-sfc";
            string password = "o-sfc.aac";

            return DBSQLServerUtils.GetDBConnection(datasource, username, password);
        }
        public static SqlConnection GetDBConnection(string db)
        {
            string datasource = @"10.8.145.155";

            //string database = "WebOnlineCode";
            string username = "o-sfc";
            string password = "o-sfc.aac";

            return DBSQLServerUtils.GetDBConnection(datasource,db, username,password);
        }
    }

}