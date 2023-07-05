using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentMvc.Models
{
    public class StudentDbHandler
    {
        // ****** sql connection *********
        SqlConnection con=null;
        public void connection()
        {
            string constr = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=SchoolDb;";
            con=new SqlConnection(constr);
        }

        //**********insert details*********
        public bool InsertRecord(StudentModel sdetail)
        {
            connection();
            string query = "Insert into Addmision values('" + sdetail.Rollno + "','" + sdetail.Name + "','" + sdetail.City + "','" + sdetail.Phone + "','" + sdetail.DOB + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else 
            { return false;}
        }

        // *********** Get List *************
        public List<StudentModel> GetRecords()
        {
            connection ();
            List<StudentModel> sdetail= new List<StudentModel> ();

            string query = "select * from Addmision";
            SqlCommand cmd= new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach(DataRow dr in dt.Rows)
            {
                sdetail.Add(new StudentModel
                {
                    Rollno = Convert.ToInt32(dr["Rollno"]),
                    Name = Convert.ToString(dr["Name"]),
                    City = Convert.ToString(dr["City"]),
                    Phone = Convert.ToString(dr["Phone"]),
                    DOB =Convert.ToString(dr["DOB"])
                }) ;
            }
            return sdetail;
        }

        // ************ Update Details ************
        public bool UpdateRecord(StudentModel sdetail)
        {
            connection();
            string query = "update Addmision set Name='" + sdetail.Name + "',City='" + sdetail.City + "',Phone='" + sdetail.Phone + "',DOB='" + sdetail.DOB + "' where Rollno=" + sdetail.Rollno;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open ();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i >=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}