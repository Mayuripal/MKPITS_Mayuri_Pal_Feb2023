using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeeshoProject
{
    public partial class checkmno : System.Web.UI.Page
    {
        string prodid;
        SqlConnection con=new SqlConnection("server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=meeshodb");
        SqlCommand cmd;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            prodid = Convert.ToString(Session["ProdId"]);
            Response.Write(prodid); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res=TextBox1.Text;
            string prodname = null;
            double prodprice = 0;
            int qty = 0;
            string sessionid = null;
            if(res=="123456")
            {
                query = "select * from Product where Prodid=@Prodid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Prodid", prodid);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    prodname = dr["Prodname"].ToString();
                    prodprice = Convert.ToDouble(dr["proudprice"]);
                     qty = 1;
                    sessionid = Session.SessionID;
                }

                con.Close();
                Response.Write("Prodname " + prodname + "<br>");
                Response.Write("Prod price " + prodprice + "<br>");
                Response.Write("Qty " + qty + "<br>");
                Response.Write("session id " + sessionid + "<br>");
            }
            else
            {
                Label1.Text = "invalid otp";
            }
        }
    }
}