using System;
using System.Data;
using System.Data.SqlClient;
//connected server type

namespace Student_detail
{
    public static class DatabaseConnection
    {
        //creating static variable
        public static string connectionString = "server=.\\sqlExpress;integrated security=true;database=details;";

        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ee)
            {
                return null;
            }
        }
        //creating static method to insert into user table
        public static string InsertRecord(string studid, string studname, string gender, string mobile, string email, string dob, string city)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into stud values(@studid,@studname,@gender,@mobile,@email,@dob,@city)";
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@studid", studid);
                command.Parameters.AddWithValue("@studname", studname);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@dob", dob);
                command.Parameters.AddWithValue("@city", city);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record inserted successfully";

            }
            catch (SqlException ee)
            {
                return ee.ToString();
            }
            finally { con.Close(); }

        }
        // creating a static method to update record into user table
        public static string UpdateUsers( string studname,long mobile)
        {
            SqlConnection con = GetConnection();
            //creating a update command
            string query = "update stud set mobile=@mobile where studname=@studname";

            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@mobile",mobile);
                command.Parameters.AddWithValue("@studname", studname);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record updated successfully";

            }
            catch (SqlException ee)
            {
                return ee.ToString();
            }
            finally { con.Close(); }

        }
        //creating a static method to delete record from users table
        public static string DeleteUsers(string studid)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "delete from stud  where studid=@studid";
            //@studid  are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters


                command.Parameters.AddWithValue("@studid", studid);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record deleted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }
         /// <summary> connected /// </summary>
         /// <returns>city in combobox</returns>
                    
        //public static SqlDataReader Getcity()//method to return city name
        //{      
                //sqldatareader is used to store record
        //    SqlConnection s=GetConnection();
        //    string query = "select * from city";
        //    try
        //    {
        //        SqlCommand command=new SqlCommand(query, s); 
        //        SqlDataReader dr = command.ExecuteReader();
        //        return dr;
                
        //    }
        //    catch { return null; }
        //}

        ///<summary> disconnected ///</summary>
        public static DataSet GetCity()
        {
            SqlConnection con = GetConnection();
            string query = "select * from city";
            try
            {
                DataSet ds = new DataSet(); 
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "city");
                return ds;
            }
            catch (Exception ee) { return null; }
        }
        //write a method for  display in datagrid view
        public static DataSet GetStudDetail()
        {
            SqlConnection con =GetConnection();
            DataSet dsa = new DataSet();
            string query = "select * from stud";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dsa, "stud");
                return dsa;
            }
            catch (Exception ee) { return null; }
            
        }

        //create a method to search data
        public static DataSet SearchStudent(string studid)
        {
            SqlConnection con = GetConnection();
            DataSet sds = new DataSet();
            string query = "select * from stud where studid=@studid";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@studid", studid);
                da.Fill(sds, "stud");
                return sds;
            }
            catch (Exception ee) { return null; }
        }
    }
}
