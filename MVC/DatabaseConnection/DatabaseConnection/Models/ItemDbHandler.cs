using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace DatabaseConnection.Models
{
    public class ItemDbHandler
    {
        // ****** sql connection *********

        SqlConnection con = null;
        public void connection()
        {
            string constr = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=compshop;";
            con = new SqlConnection(constr);
        }

        //**********insert item*********
        public bool InsertItem(ItemModel ilist)
        {
            connection();
            string query = "insert into ItemList values('" + ilist.ProdName + "','" + ilist.Category + "','" + ilist.Price + "')";
            SqlCommand cmd =new SqlCommand(query, con);
            con.Open();
            int i=cmd.ExecuteNonQuery();    
            con.Close();
            if (i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //********* Get list item ***********
        public List<ItemModel> GetItemList() 
        {
            connection();
            List<ItemModel> ilist = new List<ItemModel>();

            string query = "select * from ItemList";
            SqlCommand cmd=new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                ilist.Add(new ItemModel
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    ProdName = Convert.ToString(dr["ProdName"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            return ilist;
        }

        //********* Update item detail ************
        public bool UpdateItem(ItemModel ilist)
        {
            connection();
            string query = "update ItemList set ProdName='"+ilist.ProdName+"',Category='"+ilist.Category+"',Price='"+ilist.Price+"'where Id="+ilist.Id;
            SqlCommand cmd= new SqlCommand(query, con); 
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close() ;
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // *********** Delete item *********
        public bool DeleteItem(int Id)
        {
            connection();
            string query = "delete from ItemList where ID="+Id;
            SqlCommand cmd= new SqlCommand(query, con); 
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
