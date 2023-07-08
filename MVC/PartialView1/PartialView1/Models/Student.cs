using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EnrollmentNo { get; set; }

        public List<Student>GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { StudentId = 1, Code = "L0001", Name = "Amit Gupta", EnrollmentNo = "2014044150001" });
            students.Add(new Student { StudentId = 2, Code = "L0002", Name = "Chetana Gujjar", EnrollmentNo = "2014044150002" });
            students.Add(new Student { StudentId = 3, Code = "L0003", Name = "Ria Patel", EnrollmentNo = "2014044150003" });
            return students;
        }
    }
}