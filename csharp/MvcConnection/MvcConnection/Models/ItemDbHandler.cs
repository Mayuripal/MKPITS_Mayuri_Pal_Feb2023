using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Collections;

namespace MvcConnection.Models
{
    public class ItemDbHandler
    {
        public SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["CompShop"].ToString();
            con=new SqlConnection(constring);
        }

        //***********Get All Item List*******
        //list generic class to create collection of itemmodel objects
        public List<ItemModel>GetItemList()
        {
            connection();
            List<ItemModel> ilist = new List<ItemModel>();

            string query = "Select * From ItemList";
            SqlCommand cmd =new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                ilist.Add(new ItemModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    ProdName = Convert.ToString(dr["ProdName"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            return ilist;
        }

        //************Item list **********
        public bool InsertItem(ItemModel ilist)
        {
            connection();
            string query = "INSERT INTO ItemList VALUES('" + ilist.ProdName + "','" + ilist.Category + "'," + ilist.Price + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}