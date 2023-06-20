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
        // method to make sql connection
        SqlConnection con=new SqlConnection("server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=drivenitdb;");
        SqlCommand cmd = null;
        string query = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //method to insert record in Transaction table
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
                cmd.ExecuteNonQuery();

                Label1.Text = " record inserted ";
            }
            catch (Exception ex)
            {
                Label1.Text =ex.ToString();
            }
            finally 
            { 
                con.Close();
            }

        }

        // method to edit / update transaction table
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update Transactions set ItemId=@ItemId,TransType=@TransType,TransQty=@TransQty,TransDate=@TransDate where TransId=@TransId";

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
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@TransType", transt);
                cmd.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                cmd.Parameters.AddWithValue("@TransId", transid);
                con.Open();
                cmd.ExecuteNonQuery();

                //getting the balance quatity from item master for particular itemid
                int updateqty = 0;
                query = "select max(BalQty)from ItemMaster where ItemId=@ItemId";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(cmd.ExecuteScalar());
                updateqty = Convert.ToInt32(TextBox1.Text) - oldtransqty;


                if(RadioButton1.Checked)
                {
                    bq = bq - updateqty;
                }
                if (RadioButton2.Checked)
                {
                    bq = bq + updateqty;
                }

                Response.Write("<br>newupdated qty " + bq.ToString());
                if (bq < 0)
                {
                    Label1.Text = " Stock not avaliable ";
                }
                //if (transt == "I")
                //{
                //    bq = bq - Convert.ToInt32(TextBox1.Text);
                //}
                //else if (transt == "R")
                //{
                //    bq = bq + Convert.ToInt32(TextBox1.Text);
                //}

                //updating bal qty on item master table
                else
                {
                    query = "update ItemMaster set BalQty=@BalQty where ItemId=@ItemId";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@BalQty", bq);
                    cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                    cmd.ExecuteNonQuery();

                    Label1.Text = "record updated sucessfully";
                }
            }
            catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally 
            {
                con.Close(); 
            }

        }

        static int transid = 0;
        static int oldtransqty = 0;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            oldtransqty=Convert.ToInt32(TextBox1.Text); 

            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox2.Text = dd.ToString("yyyy-MM-dd");

            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;

            string res = GridView1.SelectedRow.Cells[3].Text;
            if(res == "I")
            {
                RadioButton1.Checked = true;
                RadioButton2.Checked = false;
            }
            if (res == "R")
            {
                RadioButton2.Checked = true;
                RadioButton1.Checked = false;
            }

            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "delete from Transactions where TransId=@TransId";
            SqlCommand cmd= new SqlCommand(query,con);

            cmd.Parameters.AddWithValue("@TransId", transid);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Label1.Text = " Record deleted ";
        }
    }
}
