using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Practise1
{
    public static  class Product
    {
        private static string connection = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database =Project1;";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                return con;
            }
            catch (Exception ee)
            { return null; }

        }

        public static DataSet GetProductCategory() 
        {
            SqlConnection con = GetConnection();
            string query = "select * from ProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds, "ProductCategory");
            return ds;

        }

        public static DataSet GetProductName(string product_type_name)
        {
            SqlConnection conn = GetConnection();
            string query = "select p.product_name from Product p inner join ProductCategory t on p.Product_Type_ID = t.Product_Category_ID where t.Product_Type_Name = Product_Type_Name;";
            DataSet ds1 =new DataSet();
            SqlDataAdapter da = new SqlDataAdapter( query,conn);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds1, "Product");
            return ds1;
        }
    }
}
