using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_example2
{
    //base class person
    class person
    {
        public string name;
        public string address;
    }

    //derived class employee
    class employee:person
    {
        public int empno;
        public int salary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.empno= 1;
            emp.salary = 21000;
            emp.name = "ria";
            emp.address = "pune";
            Console.WriteLine("emp no " + emp.empno);
            Console.WriteLine("emp name " + emp.name);
            Console.WriteLine("emp salary" + emp.salary);
            Console.WriteLine("emp address" + emp.address);
            Console.ReadLine();
        }
    }
}
