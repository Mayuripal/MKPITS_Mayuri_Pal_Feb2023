using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMvc.Models
{
    public class StudentModel
    {
        public int Rollno { get; set; } 
        public string Name { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }

    }
}