using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UserForm
{
    public static class DatabaseConnection
    {
        //creating a static variable
        private static string connectionString = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=mkpits;";
        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con=new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch(SqlException ee)
            {
                return null;
            }
        }
        //creating a static method to insert record into user table
        public static string InsertRecord(string username,string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into users values(@username,@password)";
            // @username,@password are sql parameters

            try
            {
                //creating an object of sql command class
                SqlCommand command = new SqlCommand(query, con);

                //defining sql parameter
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@Password", password);

                //executing the command using execution Query method
                command.ExecuteNonQuery();
                return "Data Added Sucessfully";

            }
            catch(SqlException ee) 
            { 
                return ee.ToString();
            }

            finally 
            {
                con.Close(); 
            }


        }


    }
}
