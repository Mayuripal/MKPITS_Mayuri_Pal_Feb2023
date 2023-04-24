using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_prog2
{
    class student
    {
        int rno;
        string name;

        //creating function
        public void getdata()
        {
            rno = 121;
            name = "neha";
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
            stud1.getdata();
            stud1.displaydata();
           
        }
    }
}
