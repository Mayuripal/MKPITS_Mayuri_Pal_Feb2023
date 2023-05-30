using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CourseRegistration
{
    public static class CourseRegistration
    {
        private static string connection = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=Registration;";

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
            string query = "select Nationid,Nationname from Nation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.Fill(ds,"Nation");
            return ds;

        }

        // method to get state
        public static DataSet GetState(string Nationname)
        {
            SqlConnection conn = GetConnection();
            string query = "select s.Stateid,s.Statename from State s inner join Nation n on s.Nationid=n.Nationid where n.Nationname=@Nationname;";
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
            string query = "select c.Cityid, c.Cityname from City c inner join State s on c.Stateid=s.Stateid where s.Statename=@Statename;";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@Statename", Statename);
            da.Fill(ds2, "City");
            return ds2;
       }

       // method to insert recordin tablecourseregdetail
       public static string Inserttablecourseregdetail( int CategoryId,string FullName,int GenderId)
       {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into TableCourseRegDetail values (@CategoryId,@FullName,@GenderId)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@CategoryId", CategoryId);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@GenderId", GenderId);

            command.ExecuteNonQuery();
            con.Close();
            return "record saved in tablecourseregdetail";

       }

        // method to insert recordin tableregaddress
        static int CourseRegId = 0;
        public static string Inserttableregaddress(int Nationid,int Stateid,int Cityid)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "select top 1 CourseRegId from TableCourseRegDetail  ORDER BY CourseRegId desc";
            SqlCommand command =new SqlCommand(query, con);
            CourseRegId=Convert.ToInt32(command.ExecuteScalar());    // returns single value
             query = "insert into TableRegAddress values(@CourseRegId,@nationid,@stateid,@cityid)";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@CourseRegId", CourseRegId);
            command.Parameters.AddWithValue("@nationid", Nationid);
            command.Parameters.AddWithValue("@stateid", Stateid);
            command.Parameters.AddWithValue("@cityid", Cityid);

            command.ExecuteNonQuery();
            con.Close();
            return "record saved in tableregaddress sucessfully  ";

        }

        // method to save fees detail
        public static string InsertTableFeeDetail(double TotalAmount,double MinPer,double PaidAmount,double BalAmount,DateTime PaidDate)
        {
            SqlConnection con = GetConnection();
            con.Open();

            string query = "insert into TableFeeDetail1 values(@CourseRegId,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand command=new SqlCommand(query, con);
            command.Parameters.AddWithValue("@CourseRegId", CourseRegId);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            command.Parameters.AddWithValue("@MinPer", MinPer);
            command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            command.Parameters.AddWithValue("@BalAmount", BalAmount);
            command.Parameters.AddWithValue("@PaidDate", PaidDate);

            command.ExecuteNonQuery();
            con.Close();
            return "record saved in TableFeeDetail ";
        }


    }
}
