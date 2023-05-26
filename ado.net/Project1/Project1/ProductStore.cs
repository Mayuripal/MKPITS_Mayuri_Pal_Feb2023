using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Project1
{
    public static class ProductStore
    {
        private static string connectionString = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=Project1;";
                                                                                                      //method to create sqlconnection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
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

                                                                                                      //method to return product category
        public static DataSet GetProductCategory()
        {
            SqlConnection conn = GetConnection();
            string query = "select * from productcategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "productcategory");
            return ds;
        }

                                                                                                      //method to return product name for given product type name
        public static DataSet GetProductName(string product_type_name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.Product_ID, p.product_name from Product p inner join ProductCategory t on p.Product_Type_ID = t.Product_Category_ID where t.Product_Type_Name = @Product_Type_Name";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds1, "product");
            return ds1;

        }

                                                                                                     //method to return %gst from product category
        public static DataSet GetPercentGst(string product_type_name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.CGST,a.SGST,a.IGST from Product_GST_Details a inner join ProductCategory b on a.Product_Gst_ID=b.Product_Gst_ID where b.Product_Type_Name=@Product_Type_Name";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", product_type_name);
            da.Fill(ds2, "Product_GST_Details");
            return ds2;
        }

                                                                                                     //method to return product price from product name
        public static DataSet GetProductPrice(string product_name)
        {
            SqlConnection con = GetConnection();
            string query = "select Product_Price from Product where Product_Name=@product_name";
            DataSet ds3 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_name", product_name);
            da.Fill(ds3, "Product");
            return ds3;
        }

                                                                                                     //method to save record inside the invoive table
        public static string InsertInvoiceDetailS(string Customer_name, string Customer_contact, int Product_Category_ID, int Product_ID, int Residential_Type_ID, DateTime Invoice_Date, decimal Quantity, decimal Price, decimal cgst, decimal sgst, decimal igst, decimal cgst_value, decimal sgst_value, decimal igst_value, decimal Total_Amount)
        {
            string result = null;
            string query = "insert into InvoiceDetail values(@Customer_name, @Customer_contact, @Product_Category_ID, @Product_ID, @Residential_Type_ID, @Invoice_Date, @Quantity, @Price,@cgst, @sgst, @igst, @cgst_value, @sgst_value, @igst_value, @Total_Amount) ";
             
            SqlConnection con = GetConnection();
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@customer_name", Customer_name);
            command.Parameters.AddWithValue("@customer_contact", Customer_contact);
            command.Parameters.AddWithValue("@Product_Category_ID", Product_Category_ID);
            command.Parameters.AddWithValue("@Product_ID", Product_ID);
            command.Parameters.AddWithValue("@Residential_Type_ID", Residential_Type_ID);
            command.Parameters.AddWithValue("@Invoice_Date", Invoice_Date);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@cgst", cgst);
            command.Parameters.AddWithValue("@sgst", sgst);
            command.Parameters.AddWithValue("@igst", igst);
            command.Parameters.AddWithValue("@cgst_value", cgst_value);
            command.Parameters.AddWithValue("@sgst_value", sgst_value);
            command.Parameters.AddWithValue("@igst_value", igst_value);
            command.Parameters.AddWithValue("@Total_amount", Total_Amount);
            try
            {
                command.ExecuteNonQuery();
                result = "Record added sucessfully";
            }
            catch(Exception ex)
            {
                result= ex.ToString();
            }
            finally
            { 
                con.Close(); 
            }
            return result;

        }
    }
}
