using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Reflection.Emit;

namespace ado2
{
    public static class DatabaseConnection
    {
        //creating static variable
        private static string ConnectionString = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security = true;database=movie;";
        //creating static method
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (SqlException EE)
            {
                return null;
            }
        }

          
    }
}
