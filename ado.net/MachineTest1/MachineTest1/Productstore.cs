using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MachineTest1
{
    public static class Productstore
    {
        private static string connection = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=project1;";

        public static SqlConnection GetConnection()
        {
            SqlConnection con=new SqlConnection(connection);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ee)
            { 
                return null;
            }
        }

        public static DataSet GetProductCatergory()
        {
            SqlConnection con = GetConnection();
            string query = "select * from productcategory";
            DataSet ds=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds, "product_category");
            return ds;

        }

        public static DataSet GetProductName(string Product_Type_Name)
        {
            SqlConnection con =GetConnection();
            string query = "select p.Product_ID, p.product_name from Product p inner join ProductCategory t on p.Product_Type_ID = t.Product_Category_ID where t.Product_Type_Name = @Product_Type_Name";
            DataSet ds=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter( query,con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "Product");
            return ds;
            
        }

        public static DataSet GetPercentGst(string Product_Type_Name)
        {
            SqlConnection con =GetConnection();
            string query = "select a.CGST,a.SGST,a.IGST from Product_GST_Details a inner join ProductCategory b on a.Product_Gst_ID=b.Product_Gst_ID where b.Product_Type_Name=@Product_Type_Name";
            DataSet ds=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "Product_GST_Details");
            return ds;

        }

        public static DataSet GetProductPrice(string Product_Name)
        {
            SqlConnection con =GetConnection();
            string query = " select Product_Price from Product where Product_Name=@product_name";
            DataSet ds=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_name", Product_Name);
            da.Fill(ds, "Product");
            return ds;
        }

        //public static string InsertRecord(string customer_name,string customer_contact,int Product_Category_ID,int Product_ID,int Residential_Type_ID,DateTime Invoice_Date,decimal Quantity,decimal cgst,decimal sgst,decimal igst,decimal cgst_value,decimal sgst_value,decimal igst_value,decimal totalamount)
        //{
        //    string result = null;
        //    string query = "insert into InvoiceDetail values(@Customer_name, @Customer_contact, @Product_Category_ID, @Product_ID, @Residential_Type_ID, @Invoice_Date, @Quantity, @Price,@cgst, @sgst, @igst, @cgst_value, @sgst_value, @igst_value, @Total_Amount)";

        //    SqlConnection con =GetConnection();
        //    SqlCommand command = new SqlCommand(query, con);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);
        //    command.Parameters.AddWithValue("@customer_contact", customer_contact);
        //    command.Parameters.AddWithValue("@Product_Category_ID", Product_Category_ID);
        //    command.Parameters.AddWithValue("@Product_ID", Product_ID);
        //    command.Parameters.AddWithValue("@Residential_Type_ID", Residential_Type_ID);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);
        //    command.Parameters.AddWithValue("@customer_name", customer_name);

        //}
        
    }
}
