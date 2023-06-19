using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace ClassLibraryTrust
{
    public static class TransactionClass
    {
        static SqlConnection con = Class1.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //method to insert into Transaction detail
        public static string TransactionIssue(int Item_Id, DateTime Transaction_Date,int Department_id,int Quantity)
        {
            string res = null;
            try
            {
                query = "insert into Transaction_Detail values(@Item_Id,@Transaction_Date,@Department_id,@Quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                cmd.Parameters.AddWithValue("@Transaction_Date", Transaction_Date);
                cmd.Parameters.AddWithValue("@Department_id", Department_id);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record saved in transaction master sucessfully";

                //code to get balance quantity for item master
                int bal_quantity =0;
                query = "select Balance_quantity from Item_master where Item_Id =@Item_Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    bal_quantity = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
                int qty = bal_quantity + Quantity;

                query = "update Item_master set Balance_quantity=@Balance_quantity where Item_Id=@Item_Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Balance_quantity", qty);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                con.Open();
                cmd.ExecuteNonQuery();

                return "item issued to department sucessfully";

            }


            catch (Exception ex)
            {
                res = ex.ToString();

            }
            finally
            { con.Close(); }

            return res;
        }

        public static string TransactionPurchase(int Item_Id, DateTime Transaction_Date, int Vendor_id, int Quantity)
        {
            string res = null;
            try
            {
                query = "insert into Transaction_Detail values(@Item_Id,@Transaction_Date,@Vendor_id,@Quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                cmd.Parameters.AddWithValue("@Transaction_Date", Transaction_Date);
                cmd.Parameters.AddWithValue("@Vendor_id", Vendor_id);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record saved in transaction master sucessfully";

                //code to get balance quantity for item master
                int bal_quantity = 0;
                query = "select Balance_quantity from Item_master where Item_Id =@Item_Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bal_quantity = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
                int qty = bal_quantity + Quantity;

                query = "update Item_master set Balance_quantity=@Balance_quantity where Item_Id=@Item_Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Balance_quantity", qty);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                con.Open();
                cmd.ExecuteNonQuery();

                return "item issued to department sucessfully";

            }


            catch (Exception ex)
            {
                res = ex.ToString();

            }
            finally
            { con.Close(); }

            return res;
        }
    }
}
