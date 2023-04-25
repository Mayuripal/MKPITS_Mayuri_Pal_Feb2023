using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Address
    {
        public string city;
        public string state;
        public Address(string city, string state)
        {
            this.city = city;
            this.state = state;
        }
    }
    class Employee
    {
        int empno;
        string name;
        Address add;//has a relation
        public Employee(int empno, string name, Address add)
        {
            this.empno = empno;
            this.name = name;
            this.add = add;
        }
        public void display()
        {
            Console.WriteLine("empno" + " " + empno);
            Console.WriteLine("name" + " " + name);
            Console.WriteLine("address" + " " +add.city);
            Console.WriteLine("address" + " " +add.state);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("Ngp", "MH");
            Employee emp = new Employee (123, "ria",a1);
            emp.display();
            Console.ReadLine();
        }
    }
}
