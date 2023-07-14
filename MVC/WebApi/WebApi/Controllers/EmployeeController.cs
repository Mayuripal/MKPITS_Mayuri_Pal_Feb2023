using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        //creating an array of object of employee class
        Employee[] employees = new Employee[]
        {
            new Employee{Id=1,Name="Shreya",JoiningDate=DateTime.Parse(DateTime.Today.ToString()),Age=23},
            new Employee{Id=2,Name="Mahima",JoiningDate=DateTime.Parse(DateTime.Today.ToString()),Age=22},
            new Employee{Id=3,Name="Rupali",JoiningDate=DateTime.Parse(DateTime.Today.ToString()),Age=23},
            new Employee{Id=4,Name="Mayuri",JoiningDate=DateTime.Parse(DateTime.Today.ToString()),Age=22},
        };

        //creating a method getallemployees to return list of employees details
        [HttpGet]
        public IEnumerable<Employee>GetEmployees()
        {
            return employees;//employees is array of object created above
        }

        //creating method getemployee acception id and then returning
        //details of that employee
        public IHttpActionResult GetEmployee(int id)
        {
            var employee=employees.FirstOrDefault((p) => p.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
