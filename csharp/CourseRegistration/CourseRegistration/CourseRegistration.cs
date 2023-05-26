using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CourseRegistration
{
    public static class CourseRegistration
    {
        private static string connection = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=Institute";

        // method to make connection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                return con;
            }
            catch (Exception ee)
            { return null; }
        }

        // method to get nation
        public static DataSet GetNation()
        {
            SqlConnection conn = GetConnection();
            string query = "select Nationname from Nation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.Fill(ds,"Nation");
            return ds;

        }

        // method to get state
        public static DataSet GetState(string Nationname)
        {
            SqlConnection conn = GetConnection();
            string query = "select s.statename from state s inner join Nation n on s.Nationid=n.Nationid where n.Nationname=@Nationname;";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Nationname", Nationname);
            da.Fill(ds1, "State");
            return ds1;



        }

        // method to get city 
       public static DataSet GetCity(string Statename)
       {
            SqlConnection con = GetConnection();
            string query = "select c.Cityname from City c inner join State s on c.Stateid=s.Stateid where s.Statename=@Statename;";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@Statename", Statename);
            da.Fill(ds2, "City");
            return ds2;
       }
    }
}
