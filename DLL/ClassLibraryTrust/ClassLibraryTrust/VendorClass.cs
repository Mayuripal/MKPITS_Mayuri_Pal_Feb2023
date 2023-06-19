using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTrust
{
    public static class VendorClass
    {
        static SqlConnection con = Class1.GetConnection();
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

        //method to return vendor_id
        public static string getVendor_Id()
        {
            string res = null;
            try
            {
                query = "select max(Vendor_id)from Vendor_mast";
                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());

                res = vid.ToString();
            }
            catch(Exception ee)
            {
                res = ee.ToString();
            }
            finally
            { 
                con.Close();
            }
            return res;
        }

        //method to update vendor table
        public static string updateVendor_Mast(string Vendor_name,int Vendor_id)
        {
            string res = null;

            //checking whether vendorid exist or not
            query = "select count(*) from Vendor_mast where Vendor_id=@Vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Vendor_id", Vendor_id);
            con.Open();
            int cnt=Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if(cnt > 0)
            {
                try
                {
                    query = "update Vendor_mast set Vendor_name=@Vendor_name where Vendor_id=@Vendor_id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Vendor_name", Vendor_name);
                    cmd.Parameters.AddWithValue("@Vendor_id", Vendor_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in vendor master sucessfully";
                }
                catch(Exception ee)
                {
                    res = ee.ToString();
                }
                finally { con.Close(); }
            }
            else
            {
                res = "no record exist";
            }
            return res;
        }

        //method to delete record in vendor master
        public static string deleteVendor_Mast(int Vendor_id)
        {
            string res = null;

            //checking whether vendorid exist or not
            query = "select count(*) from Vendor_mast where Vendor_id=@Vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Vendor_id", Vendor_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if(cnt > 0)
            {
                try
                {
                    query = "delete from Vendor_mast where Vendor_id=@Vendor_id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Vendor_id", Vendor_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record deleted in vendor master sucessfully";

                }
                catch(Exception ee)
                {
                    res = ee.ToString();
                }
                finally { con.Close(); }
            }
            else
            {
                res = "no record exist";
            }
            return res;

        }

        //method to search record in vendor master
        public static DataSet searchVendor_Mast(int Vendor_id)
        {
            
            query = "select * from Vendor_mast where Vendor_id=@Vendor_id";
            DataSet ds =new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            da.SelectCommand.Parameters.AddWithValue("@Vendor_id", Vendor_id);
            da.Fill(ds, "Vendor_mast");
            return ds;

            
        }
    }
}
