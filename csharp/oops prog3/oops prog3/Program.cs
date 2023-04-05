using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_prog3
{
    //create a class having feilds and method with parameter
    class student
    {
        int rno;
        string name;
    //creating member function

        public void getdata(int r,string n)
        {
            rno= r;
            name= n;
        }
        public void displaydata()
        {
            Console.WriteLine("roll no :" + rno);
            Console.WriteLine("name :" + name);
            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();
            stud1.getdata(1231, "mayuri");
            stud1.displaydata();
        }
    }
}
