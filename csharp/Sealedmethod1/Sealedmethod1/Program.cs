using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealedmethod1
{
    //create a class student
    class Student
    {
        public virtual void display()
        {
            Console.WriteLine("hello from student ");
        }
    }
    class Engineer :Student 
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
