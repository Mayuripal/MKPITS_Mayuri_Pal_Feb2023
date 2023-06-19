using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StoreLibrary
{
    internal class Dbconnection
    {
        public static SqlConnection con;
        public static SqlConnection GetConnection()
        {
            con = new SqlConnection("server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=dbStoreDLL;");

            return con;
        }



    }
}
