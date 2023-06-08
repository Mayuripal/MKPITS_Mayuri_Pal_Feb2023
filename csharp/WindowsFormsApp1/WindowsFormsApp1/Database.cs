using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public static class Database
    {
        //make connection
        private static string connection = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=project3;";

        public static SqlConnection GetConnection()
        {
            SqlConnection con =new SqlConnection(connection);
            try
            {
                con.Open();
                return con;
            }
            catch 
            { return null; }  
        }

        //method to fill combobox1 with nation name
        public static DataSet GetNation()
        {
            SqlConnection conn = GetConnection();
            string query = "select F2 from Details";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.Fill(ds,"Details");
            return ds;
        }
    }
}
