using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Input;

namespace Aspcrude
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //making a sql connection
        SqlConnection con=new SqlConnection("server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=company;");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //load button
        protected void Button5_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        //method to load data
        public void loaddata()
        {
            str = "select * from product_qty";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "product_qty");
            GridView1.DataSource = ds.Tables["product_qty"].DefaultView;
            GridView1.DataBind();
        }

        // method to insert data
        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into product_qty values (@Region,@product,@year,@quantity,@price)";
            SqlCommand command =new SqlCommand(str, con);

            command.Parameters.AddWithValue("@Region",(TextBox2.Text));
            command.Parameters.AddWithValue("@product",(TextBox3.Text));
            command.Parameters.AddWithValue("@year",Convert.ToInt32(TextBox4.Text));
            command.Parameters.AddWithValue("@quantity",Convert.ToInt32(TextBox5.Text));
            command.Parameters.AddWithValue("@Price",Convert.ToDecimal(TextBox6.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted";
            loaddata();
        }

        

        // method to update data
        protected void Button2_Click1(object sender, EventArgs e)
        {
            str = "update product_qty set Region=@Region,year=@year,quantity=@quantity,price=@price where product=@product";
            SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("@Region", (TextBox2.Text));
            command.Parameters.AddWithValue("@year", Convert.ToInt32(TextBox4.Text));
            command.Parameters.AddWithValue("@quantity", Convert.ToInt32(TextBox5.Text));
            command.Parameters.AddWithValue("@Price", Convert.ToDecimal(TextBox6.Text));
            command.Parameters.AddWithValue("@product", (TextBox3.Text));
            //command.Parameters.AddWithValue("@id",Convert.ToInt32(TextBox1.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated";
            loaddata();
        }

        // method to delete data
        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from product_qty where year=@year";
            SqlCommand command =new SqlCommand(str, con);

            command.Parameters.AddWithValue("@year", Convert.ToInt32(TextBox4.Text));
            
            con.Open() ;
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record delete";
            loaddata();

        }

        // method to search data
        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from product_qty where product=@product";
            da=new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@product", (TextBox3.Text));
            da.Fill(ds, "product_qty");

            GridView1.DataSource = ds.Tables["product_qty"].DefaultView;
            GridView1.DataBind();
        }

        



    }
}