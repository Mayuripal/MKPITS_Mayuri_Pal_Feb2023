using ClassLibraryTrust;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TrustProject
{
    public partial class Item : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = ItemClass.insertItem_Mast(TextBox2.Text,DropDownList1.Text,Convert.ToInt32(TextBox3.Text),Convert.ToInt32(TextBox4.Text));
            Label1.Text = res;
            //getItemId();
            TextBox1.Text = " ";
        }

        public void getItemId()
        {
            int res = Convert.ToInt32(ItemClass.getItem_Id());
            res = res + 1;
            TextBox1.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = ItemClass.updateItem_Mast(TextBox2.Text,DropDownList1.Text,Convert.ToInt32(TextBox3.Text), Convert.ToInt32(TextBox4.Text), Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = ItemClass.deleteItem_Mast(Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = ItemClass.searchItem_Mast(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox2.Text = ds.Tables["Item_master"].Rows[0].ItemArray[1].ToString(); 
                TextBox3.Text = ds.Tables["Item_master"].Rows[0].ItemArray[3].ToString(); 
                TextBox4.Text = ds.Tables["Item_master"].Rows[0].ItemArray[4].ToString(); 
            }
            else
            {
                Label1.Text = "no record exist";
            }
        }
    }
    
}