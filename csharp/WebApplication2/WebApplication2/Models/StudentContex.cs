using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class StudentContex:DbContext
    {
        // creating a constructor and calling the base class constructor and passing the database name
        public StudentContex():base("StudentDatabase")
        {

        }
        // creating a property
        public DbSet<Student> Students { get; set; }
    }
}