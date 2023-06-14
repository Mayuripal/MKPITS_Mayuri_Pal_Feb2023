using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project4
{
    public partial class Item : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=StoreManagement;");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void loaddata()
        {
            str = "select * from Item_master";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "Item_master");
            GridView1.DataSource = ds.Tables["Item_master"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Item_master values(@Item_Id,@Category,@Item_Name,@Rate,@Balance_quantity)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Item_Id", (Convert.ToInt32(TextBox3.Text)));
            command.Parameters.AddWithValue("@Category", DropDownList1.SelectedValue);
            command.Parameters.AddWithValue("@Item_Name", (TextBox4.Text));
            command.Parameters.AddWithValue("@Rate", (Convert.ToInt32(TextBox5.Text)));
            command.Parameters.AddWithValue("@Balance_quantity", (Convert.ToInt32(TextBox6.Text)));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            loaddata();
            Label1.Text = "inserted sucessfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Item_master set Item_Name=@Item_Name where Item_Id=@Item_Id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Item_Name", (TextBox4.Text));
            command.Parameters.AddWithValue("@Item_Id", (Convert.ToInt32(TextBox3.Text)));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            loaddata();
            Label1.Text = "updated sucessfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Item_master where Item_Id=@Item_Id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Item_Id", (Convert.ToInt32(TextBox3.Text)));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            loaddata();
            Label1.Text = "delete sucessfully";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Item_master where Item_Id=@Item_Id";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@Item_Id", (Convert.ToInt32(TextBox3.Text)));
            da.Fill(ds, "Item_master");

            GridView1.DataSource = ds.Tables["Item_master"].DefaultView;
            GridView1.DataBind();
        }
    }
}