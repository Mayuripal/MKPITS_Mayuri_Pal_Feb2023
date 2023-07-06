using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudName { get; set; }

        public string Course { get; set; }

        public int Age { get; set; }    
    }
}