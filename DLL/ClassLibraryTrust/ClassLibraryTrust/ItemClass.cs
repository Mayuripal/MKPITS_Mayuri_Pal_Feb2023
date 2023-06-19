using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibraryTrust
{
    public static class ItemClass
    {
        static SqlConnection con = Class1.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //method to insert into Item master
        public static string insertItem_Mast(string Item_Name, string Category, int Rate, int Balance_quantity)
        {
            string res = null;
            try
            {
                query = "insert into Item_master values(@Item_Name,@Category,@Rate,@Balance_Quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Name", Item_Name);
                cmd.Parameters.AddWithValue("@Category", Category);
                cmd.Parameters.AddWithValue("@Rate", Rate);
                cmd.Parameters.AddWithValue("@Balance_quantity", Balance_quantity);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record saved in item master sucessfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();

            }
            finally
            { con.Close(); }

            return res;
        }

        // method to return item id
        public static string getItem_Id()
        {
            string res = null;
            try
            {
                query = "select max(Item_id)from Item_master";
                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());

                res = vid.ToString();
            }
            catch (Exception ee)
            {
                res = ee.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }

        //method to update item master 
        public static string updateItem_Mast(string Item_Name, string Category, int Rate, int Balance_quantity, int Item_Id)
        {
            string res = null;

            //checking whether vendorid exist or not
            query = "select count(*) from Item_master where Item_Id=@Item_Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {
                try
                {
                    query = "update Item_master set Item_Name=@Item_Name,Category=@Category,Rate=@Rate,Balance_quantity=@Balance_quantity where Item_Id=@Item_Id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Item_Name", Item_Name);
                    cmd.Parameters.AddWithValue("@Category", Category);
                    cmd.Parameters.AddWithValue("@Rate", Rate);
                    cmd.Parameters.AddWithValue("@Balance_quantity", Balance_quantity);
                    cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in item  master sucessfully";
                }
                catch (Exception ee)
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

        // method to delete record from item master
        public static string deleteItem_Mast(int Item_Id)
        {
            string res = null;

            //checking whether Itemid exist or not
            query = "select count(*) from Item_master where Item_Id=@Item_Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {
                try
                {
                    query = "delete from Item_master where Item_Id=@Item_Id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record deleted in item master sucessfully";

                }
                catch (Exception ee)
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

        // method to search records in item master
        public static DataSet searchItem_Mast(int Item_Id)
        {

            query = "select * from Item_master where Item_Id=@Item_Id";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            da.SelectCommand.Parameters.AddWithValue("@Item_Id", Item_Id);
            da.Fill(ds, "Item_master");
            return ds;

        }
    }
}
