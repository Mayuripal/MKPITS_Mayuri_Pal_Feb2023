using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

        }
    }
}