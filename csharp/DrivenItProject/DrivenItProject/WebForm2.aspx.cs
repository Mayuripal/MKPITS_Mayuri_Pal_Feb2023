using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DrivenItProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection("server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=drivenitdb;");
        SqlCommand cmd = null;
        string query = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                query = "insert into Transactions values(@ItemId,@TransType,@TransQty,@TransDate)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                cmd.Parameters.AddWithValue("@TransType", transt);
                cmd.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                con.Open();
                cmd.ExecuteNonQuery();

                //getting the balance quatity from item master for particular itemid
                query = "select max(BalQty)from ItemMaster where ItemId=@ItemId";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int bq=Convert.ToInt32(cmd.ExecuteScalar());
                if(transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }

                //updating bal qty on item master table
                query = "update ItemMaster set BalQty=@BalQty where ItemId=@ItemId";
                 cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BalQty", bq);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery ();

                Label1.Text = " record inserted ";
            }
            catch (Exception ex)
            {
                Label1.Text =ex.ToString();
            }
            finally { con.Close(); }

            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update Transactions set TransType=@TransType,TransQty=@TransQty,TransDate=@TransDate where ItemId=@ItemId";

                cmd = new SqlCommand(query, con);
                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                cmd.Parameters.AddWithValue("@TransType", transt);
                cmd.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                cmd.Parameters.AddWithValue("@ItemId",DropDownList1.SelectedValue);
                con.Open();
                cmd.ExecuteNonQuery();

                //getting the balance quatity from item master for particular itemid
                query = "select max(BalQty)from ItemMaster where ItemId=@ItemId";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(cmd.ExecuteScalar());
                if (transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }

                //updating bal qty on item master table
                query = "update ItemMaster set BalQty=@BalQty where ItemId=@ItemId";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BalQty", bq);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                Label1.Text = "record updated sucessfully";

            }
            catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { con.Close(); }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[5].Text;
        }
    }
}
