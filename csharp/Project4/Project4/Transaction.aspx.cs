using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project4
{
    public partial class Transaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                Label3.Visible = false; 
                DropDownList3.Visible = false;
                Label2.Visible = true;
                DropDownList2.Visible = true;

            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                Label2.Visible = false;
                DropDownList2.Visible = false;
                Label3.Visible = true;
                DropDownList3.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = null;
            SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=StoreManagement;");
            SqlCommand command;

            if (RadioButton1.Checked)
            {
                try
                {
                    query = "insert into Transaction_Detail(Item_Id,Transaction_Date,Department_Id,Quantity) values(@Item_Id,@Transaction_Date,@Department_id,@Quantity)";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    command.Parameters.AddWithValue("@Transaction_Date", TextBox1.Text);
                    command.Parameters.AddWithValue("@Department_id", DropDownList2.SelectedValue);
                    command.Parameters.AddWithValue("@Quantity",(Convert.ToInt32(TextBox2.Text)));
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    //code to get balance_quantity from item_master table
                    int bal_qty = 0;
                    query = "select Balance_quantity from Item_master where Item_Id=@Item_Id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bal_qty = Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();
                    //  Response.Write("bal qty " + bal_qty.ToString());
                    int qty = bal_qty - Convert.ToInt32(TextBox2.Text);

                    query = "update Item_master set Balance_quantity=@Balance_quantity where Item_Id=@Item_Id";

                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Balance_quantity", qty);
                    command.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    con.Open();
                    command.ExecuteNonQuery();
                    //con.Close();
                    Label1.Text = "item issued to department successfully";


                }
                catch (Exception ee)
                {
                    Label1.Text = ee.ToString();
                }
                finally
                {
                    con.Close();
                }
            }

        }
    }
}