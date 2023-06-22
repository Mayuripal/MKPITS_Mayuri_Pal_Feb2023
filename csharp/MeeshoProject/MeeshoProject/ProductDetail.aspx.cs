using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeeshoProject
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        // making a sql connection
        SqlConnection con = new SqlConnection("server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=meeshodb");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            // method to get details using product id

            string prodid = Request.QueryString["Prodid"].ToString();
            da = new SqlDataAdapter("select * from Product where Prodid=@Prodid",con);
            da.SelectCommand.Parameters.AddWithValue("@Prodid", prodid);
            ds= new DataSet();
            da.Fill(ds,"ProductDetail");
            DataList1.DataSource = ds.Tables["ProductDetail"].DefaultView;
            DataList1.DataBind();   
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}