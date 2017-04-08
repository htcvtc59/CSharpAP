using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemo.DAO
{
    class DBConnection
    {
        public static SqlConnection getConnection()
        {
            string connectionString = "Data Source=DESKTOP-R8GBISR;Initial Catalog=test_app;Persist Security Info=True;User ID=sa;Password=123456";
            return new SqlConnection(connectionString);
        }
    }
}
