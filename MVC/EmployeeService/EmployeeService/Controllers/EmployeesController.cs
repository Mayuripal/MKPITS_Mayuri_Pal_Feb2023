using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeService.Models;

namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<EmployeesController> Get()
        {
            using (EmployeeDBContext dBContext=new EmployeeDBContext())
            {
                return dBContext.Employees.ToList();
            }
        }

        //public EmployeesController Get(int id)
        //{
        //    using (EmployeeDBContext dBContext=new EmployeeDBContext())
        //    {
        //        return dBContext.Employees.FirstOrDefault(e => e.ID == id);
        //    }
        //}
    }
}
