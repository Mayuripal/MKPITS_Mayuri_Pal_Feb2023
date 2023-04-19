using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_axcessmodifier
{
    public class person
    { 
        string name;
        string address;
        protected void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected void displaypersondata()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("address :" + address);
        }
    }
    public class student : person
    {
        int rno;
        int marks;
        public void getstudentdata(int rno,int marks)
        {
            //calling base class method from derived class
            getpersondata("ria", "nagpur");
            this.rno = rno;
            this.marks = marks;
        }
        public void displaystudentdata() 
        {
            //calling base class method from derived class
            displaypersondata();
            Console.WriteLine("rno :" + rno);
            Console.WriteLine("marks :" + marks);

        }
    }
     
    class testinheritance
    { 
        static void Main(string[] args)
        {
            //creating object of child class
            student s1=new student();
            s1.getstudentdata(123, 43);
            s1.displaystudentdata();
            Console.ReadLine();
            
        }
    }
}
