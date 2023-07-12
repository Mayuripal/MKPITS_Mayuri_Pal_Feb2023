using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BankKyc
{
    public partial class Kyc : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=Bank;");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    string gen = null;
                    if (RadioButtonMale.Checked)
                    {
                        gen = "Male";
                    }
                    else if (RadioButtonFemale.Checked)
                    {
                        gen = "Female";
                    }
                    string query = "insert into TableKyc values(@FirstName,@LastName,@Mobile,@Email,@Gender)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FirstName", TextBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", TextBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@Mobileno", TextBoxMobile.Text);
                    cmd.Parameters.AddWithValue("@Email", TextBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@Gender", gen);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Label1.Text = "Kyc Registration";
                }
                catch (Exception ex)
                {
                    Label1.Text = ex.ToString();
                }
                finally { con.Close(); }
            }
        }
    }
}