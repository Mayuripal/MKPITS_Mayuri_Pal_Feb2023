using AspWebForm4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace AspWebForm4.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection con;
        //To Handle connection related activities
        private void connection ()
        {
            string constr = "server=LAPTOP-90P567RC\\SQLEXPRESS;integrated security=true;database=EmployeeDetails;";
            con=new SqlConnection (constr);
        }
        // GET: Home
        public ActionResult AddEmployee()
        {
            return View();
        }

        //post method to add detailss
        [HttpPost]
        public ActionResult AddEmployee(EmpModel obj)
        {
            AddDetails(obj);
            return View();
        }
        //to add record
        private void AddDetails(EmpModel obj) 
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddEmployee", con);
            // addtemp is the name of stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", obj.Name);
            cmd.Parameters.AddWithValue("@City", obj.City);
            cmd.Parameters.AddWithValue("@Address", obj.Address);
            con.Open ();
            cmd.ExecuteNonQuery ();
            con.Close ();
        }
        [HttpPost]
        public ActionResult UpdateEmployee(EmpModel obj)
        {
            UpdateDetails(obj);
            return View();
        }
        //to update record
        private void UpdateDetails(EmpModel obj)
        {
            connection();
            SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
            // addtemp is the name of stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", obj.Name);
            cmd.Parameters.AddWithValue("@City", obj.City);
            cmd.Parameters.AddWithValue("@Address", obj.Address);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

       
        [HttpPost]
        public ActionResult DeleteEmployee(EmpModel obj)
        {
            DeleteDetails(obj);
            return View();
        }
        //to update record
        private void DeleteDetails(EmpModel obj)
        {
            connection();
            SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
            // addtemp is the name of stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", obj.Name);
            cmd.Parameters.AddWithValue("@City", obj.City);
            cmd.Parameters.AddWithValue("@Address", obj.Address);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}