using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BlokForm
{
    class BDUtils
    {
        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = @"Data Source=K218PREP;Initial Catalog=TortiWS;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
        public static SqlConnection GetDBConnection2()
        {

            string datasource = @"K218PREP";

            string database = "TortiWS";
            string username = "sa";
            string password = "";

            return BDUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
