using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace InvoiceGeneration
{
    public static  class Invoice
    {
        private  static string connection = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security =true; DataBase=InvoiceGeneration;";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                //conn.Open();
                return conn;
            }
            catch (Exception ee)
            { 
            return null;
            }
        }

        public static DataSet GetProduct()
        {
            SqlConnection con = GetConnection();
            string query = "select * from COMPUTER";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query ,con);
            da.Fill(ds,"COMPUTER");
            return ds;
        }

        public static DataSet GetProductDetail(string NAME)
        {
            SqlConnection con = GetConnection();
            string query = "select * FROM COMPUTER WHERE NAME=@NAME";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter( query ,con);
            da.SelectCommand.Parameters.AddWithValue("@NAME", NAME);
            da.Fill(ds1, "CUSTOMER");
            return ds1;
        }

        
    }
}
