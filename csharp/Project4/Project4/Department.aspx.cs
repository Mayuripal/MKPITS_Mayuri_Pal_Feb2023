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
    public partial class Department : System.Web.UI.Page
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
            str = "select * from Department_mast";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "Department_mast");
            GridView1.DataSource = ds.Tables["Department_mast"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            str = "insert into Department_mast values(@Department_id,@Department_name)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Department_id", (Convert.ToInt32(TextBox1.Text)));
            command.Parameters.AddWithValue("@Department_name", (TextBox2.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            loaddata();
            Label1.Text = "inserted sucessfully";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            str = "update Department_mast set Department_name=@Department_name where Department_id=@Department_id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Department_name", (TextBox2.Text));
            command.Parameters.AddWithValue("@Department_id", (Convert.ToInt32(TextBox1.Text)));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            loaddata();
            Label1.Text = "update sucessfully";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            str = "delete from Department_mast where Department_id=@Department_id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Department_id", (Convert.ToInt32(TextBox1.Text)));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            loaddata();
            Label1.Text = "delete sucessfully";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            str = "select * from Department_mast where Department_id=@Department_id";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@Department_id", (Convert.ToInt32(TextBox1.Text)));
            da.Fill(ds, "Department_mast");

            GridView1.DataSource = ds.Tables["Department_mast"].DefaultView;
            GridView1.DataBind();
        }
    }
}