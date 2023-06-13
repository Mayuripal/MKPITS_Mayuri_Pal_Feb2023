using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project4
{
    public partial class Vendor : System.Web.UI.Page
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
            str = "select * from Vendor_mast";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "Vendor_mast");
            GridView1.DataSource = ds.Tables["Vendor_mast"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Vendor_mast values(@Vendor_id,@Vendor_name)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Vendor_id",(Convert.ToInt32(TextBox1.Text)));
            command.Parameters.AddWithValue("@Vendor_name",(TextBox2.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            loaddata();
            Label1.Text = "inserted sucessfully";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Vendor_mast set Vendor_name=@Vendor_name where Vendor_id=@Vendor_id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Vendor_name",(TextBox2.Text));
            command.Parameters.AddWithValue("@Vendor_id",(Convert.ToInt32(TextBox1.Text)));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            loaddata();
            Label1.Text = "update sucessfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Vendor_mast where Vendor_id=@Vendor_id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Vendor_id",(Convert.ToInt32(TextBox1.Text)));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            loaddata();
            Label1.Text = "delete sucessfully";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Vendor_mast where Vendor_id=@Vendor_id";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@Vendor_id", (Convert.ToInt32(TextBox1.Text)));
            da.Fill(ds, "Vendor_mast");

            GridView1.DataSource = ds.Tables["Vendor_mast"].DefaultView;
            GridView1.DataBind();
        }
    }
}