using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StoreLibrary
{
    public static class Class1
    {
        static SqlConnection con = Dbconnection.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //method to insert record in vendor table
        public static string insertVendor_Mast(string Vendor_Name)
        {
            string res = null;
            try
            {
                query = "insert into Vendor_mast values(@vendor_name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Vendor_Name", Vendor_Name);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record saved in vendor master sucessfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();

            }
            finally
            { con.Close(); }

            return res;
        }

        //method to return vendor id
        public static string getVendor_Id()
        {
            string res = null;
            try
            {
                query = "select max(Vendor_id) from Vendor_mast";

                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());

                res = vid.ToString();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();

            }
            return res;
        }
    }
}
