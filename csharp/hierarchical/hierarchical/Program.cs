using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical
{
    class person
    {
        public string name;
        public string address;
    }
    class student : person
    {
        public int rno;
        public int marks;
    }
    class employee : person
    {
        public int salary;
        public string designation;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of student class
            student s = new student();
            s.name = "amit";
            s.address = "nagpur";
            s.rno = 44;
            s.marks = 999;
            Console.WriteLine("--------------- student details ----------");
            Console.WriteLine("name -" + s.name);
            Console.WriteLine("addres -" + s.address);
            Console.WriteLine("rno -" + s.rno);
            Console.WriteLine("marks -" + s.marks);

            //creating object of emp class
            employee s1 = new employee();
            s1.name = "anjali";
            s1.address = "mumbai";
            s1.salary = 100000;
            s1.designation = "manager";
            Console.WriteLine("--------------employee details---------");
            Console.WriteLine("name -" + s1.name);
            Console.WriteLine("Address -" + s1.address);
            Console.WriteLine("designation -" + s1.designation);
            Console.WriteLine("salary -" + s1.salary);
            Console.ReadLine();

        }
    }
}
