using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedcClass
{
    sealed class Employee
    {
        public void showdata()
        {
            Console.WriteLine("hello");
            Console.ReadLine();
        }

    }
    class program
    { 
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.showdata();
        }
    }
}
