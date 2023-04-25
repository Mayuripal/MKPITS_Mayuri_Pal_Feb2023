using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedMethod
{
    class Person
    {
        public virtual void display()
        {
            Console.WriteLine("hello from person");
        }
    }
    class Student :Person
    {
        public sealed override void display()
        {
            Console.WriteLine("hello from student");
        }
    }
    class Partstudent :Student
    {
        public  void pshow()
        { Console.WriteLine("hello"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Partstudent s = new Partstudent();   
            s.display();
            s.pshow();
            Console.ReadLine();
        }
    }
}
