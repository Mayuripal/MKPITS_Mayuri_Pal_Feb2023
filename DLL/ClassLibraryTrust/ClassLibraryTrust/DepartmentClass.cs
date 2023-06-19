using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryTrust
{
    public static  class DepartmentClass
    {
        static SqlConnection con = Class1.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //method to insert record in department table
        public static string insertDepartment_Mast(string Department_name)
        {
            string res = null;
            try
            {
                query = "insert into Department_mast values(@Department_name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Department_name", Department_name);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record saved in department master sucessfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();

            }
            finally
            { con.Close(); }

            return res;
        }

        //method to return department id
        public static string getDepartment_Id()
        {
            string res = null;
            try
            {
                query = "select max(Department_id)from Department_mast";
                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());

                res = vid.ToString();
            }
            catch (Exception ee)
            {
                res = ee.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }

        //method to modify department name
        public static string updateDepartment_Mast(string Department_name, int Department_id)
        {
            string res = null;

            //checking whether vendorid exist or not
            query = "select count(*) from Department_mast where Department_id=@Department_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Department_id", Department_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {
                try
                {
                    query = "update Department_mast set Department_name=@Department_name where Department_id=@Department_id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Department_name",Department_name);
                    cmd.Parameters.AddWithValue("@Department_id", Department_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in department  master sucessfully";
                }
                catch (Exception ee)
                {
                    res = ee.ToString();
                }
                finally { con.Close(); }
            }
            else
            {
                res = "no record exist";
            }
            return res;
        }

        //method to delete dapartment master
        public static string deleteDepartment_Mast(int Department_id)
        {
            string res = null;

            //checking whether vendorid exist or not
            query = "select count(*) from Department_mast where Department_id=@Department_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Department_id",Department_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {
                try
                {
                    query = "delete from Department_mast where Department_id=@Department_id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Department_id",Department_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record deleted in Department master sucessfully";

                }
                catch (Exception ee)
                {
                    res = ee.ToString();
                }
                finally { con.Close(); }
            }
            else
            {
                res = "no record exist";
            }
            return res;

        }

        //method to search record from department master
        public static DataSet searchDepartment_Mast(int Department_id)
        {

            query = "select * from Department_mast where Department_id=@Department_id";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            da.SelectCommand.Parameters.AddWithValue("@Department_id",Department_id);
            da.Fill(ds, "Department_mast");
            return ds;


        }
    }
}
