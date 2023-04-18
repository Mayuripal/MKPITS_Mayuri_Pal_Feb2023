using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    //creating a base class person  
    class person
    {
        public string name;
    }
    //creating a derived class student
    class student:person
    {
        public int rno;
    }

    class Program
    {
        static void Main(string[] args)
        {
            student s=new student();
            s.name = "amit";
            s.rno = 12;
            Console.WriteLine("roll no. :"+s.rno);
            Console.WriteLine("name :" + s.name);
            Console.ReadLine();
        }
    }
}
