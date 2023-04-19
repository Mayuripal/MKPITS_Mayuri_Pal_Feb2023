using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical__example2
{
    public class person
    {
         string name;
         string address;
        public void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("address :" + address);
        }
    }
    public class student : person
    {
        int rno;
        int mark;
        public void getstudentdata(int rno,int mark) 
        {
            this.rno = rno;
            this.mark = mark;
        }
        public void displaystudentdata()
        {
            Console.WriteLine("roll no :" + rno);
            Console.WriteLine("marks :" + mark);
        }
    }
    public class employee : person
    {
        int salary;
        string designation;
        public void getemployeedata(int salary,string designation)
        {
            this.designation = designation;
            this.salary = salary;
        }
        public void displayemployeedata()
        {
            Console.WriteLine("designation :"+designation);
            Console.WriteLine("salary :" + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of student class
            student p1 = new student();//creating object of child class\
            p1.getpersondata("sania", "nagpur");
            p1.getstudentdata(111, 999);
            p1.displaypersondata();
            p1.displaystudentdata();

            //creating object of employee class
            employee e1 = new employee();
            e1.getpersondata("dinesh", "nagpur");
            e1.getemployeedata(9999, "manager");
            e1.displaypersondata();
            e1.displayemployeedata();
            Console.ReadLine();

        }
    }
}
