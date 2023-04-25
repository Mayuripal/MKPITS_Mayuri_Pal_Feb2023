using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeStatic
{
    class Employee
    {
        public int empno;
        public string name;
        public static string cname = "silica";
        public Employee(int empno,string name) 
        { 
            this.empno = empno;
            this.name = name;   
        }
        public void display()
        {
            Console.WriteLine("Company name :" + cname);
            Console.WriteLine("Employee name :" + name);
            Console.WriteLine("Employee no. :" + empno);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(3214, "mayuri");
            Employee e2 = new Employee(67214, "neha");
            
            e1.display();

            e2.display();   
           

        }
    }
}
