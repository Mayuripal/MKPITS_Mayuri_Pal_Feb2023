using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace studentdetail
{
    public static class InsertDatabase
    {
        //creating a static variable
        private static string connectionString = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=details;";

        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con; 
            }
            catch (SqlException ex) 
            {
                return null;
            }
        }
        //creating static method to insert record into user table
        public static string InsertRecord(string rollno,string firstname,string lastname,string city,string course)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into studdetail values(@rollno,@firstname,@lastname,@city,@course)";
                                                            //sql parameters
            try
            {
                //creating an object of sql command class
                SqlCommand command = new SqlCommand(query, con);
                //defining sql parameters
                command.Parameters.AddWithValue("@rollno", rollno);
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@course", course);
                //executing the command using executionquery method
                command.ExecuteNonQuery();
                return "record inserted sucessfully";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            finally 
            { con.Close(); }
        }
    }
}
