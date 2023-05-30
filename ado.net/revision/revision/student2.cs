using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace revision
{
    public static class student2
    {
        private static string connection = "server=LAPTOP-90P567RC\\SQLEXPRESS; integrated security=true;database=Institute;";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataSet GetNation()
        {
            SqlConnection con = GetConnection();
            string query = "select Nationname from Nation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds,"Nation");
            return ds;
        }

        public static DataSet GetState(string Nationname)
        {
            SqlConnection con = GetConnection();
            string query = "select s.statename from state s inner join Nation n on s.Nationid=n.Nationid where n.Nationname=@Nationname;";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da =new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@Nationname", Nationname);
            da.Fill(ds1, "State");
            return ds1;
        }


        public static DataSet GetCity(string Statename)
        {
            SqlConnection con = GetConnection();
            string query = "select c.Cityname from City c inner join State s on c.Stateid=s.Stateid where s.Statename=@Statename;";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Statename", Statename);
            da.Fill(ds2, "City");
            return ds2;
        }
    }
}
