using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    public static  class student
    {
        private static string connection = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=project2;";

        public static SqlConnection GetConnection()
        {
            SqlConnection con=new SqlConnection(connection);
            try
            {
                return con;
            }
            catch (Exception ee)
            { 
                return null;
            }
        }

        public static DataSet GetCountryName()
        {
            SqlConnection con = GetConnection();
            string query = "select countryname from country where countryname=India;";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds,"country");
            return ds;

        }

        //course

        public static DataSet GetCoursename()
        {
            SqlConnection con = GetConnection();
            string query = "select coursename from course";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds1, "course");
            return ds1;

        }
    }
}
