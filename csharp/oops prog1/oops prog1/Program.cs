using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_prog1
{
    // Example to create class student
    class student
    {
        public int rno;
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();
            stud1.rno = 123;
            stud1.name = "amit";

            Console.WriteLine("roll no. :" + stud1.rno);
            Console.WriteLine("name :" + stud1.name);
            Console.ReadLine();

        }
    }
}
