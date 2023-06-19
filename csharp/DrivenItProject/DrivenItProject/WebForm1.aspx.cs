using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DrivenItProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=drivenitdb;");
        SqlCommand cmd = null;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into ItemMaster values(@ItemDescr,@BalQty,@CreatedOn)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ItemDescr", TextBox1.Text);
                cmd.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox2.Text));
                cmd.Parameters.AddWithValue("@CreatedOn", TextBox3.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "recorded inserted ";

            }
            catch (Exception ee)
            { 
                Label1.Text = ee.ToString();
            }
            finally { con.Close(); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update ItemMaster set BalQty=@BalQty,CreatedOn=@CreatedOn where ItemDescr=@ItemDescr";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox2.Text));
                cmd.Parameters.AddWithValue("@CreatedOn", TextBox3.Text);
                cmd.Parameters.AddWithValue("@ItemDescr", TextBox1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "record updated";
            }
            catch(Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally { con.Close(); }
        }
    }
}