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
        // method for sql connection

        SqlConnection con = null;
        public void connection()
        {
            string constr = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=compshop;";
            con = new SqlConnection(constr);
        }

        //insert itemmethod to insert record into itemlist table
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
    }
}
