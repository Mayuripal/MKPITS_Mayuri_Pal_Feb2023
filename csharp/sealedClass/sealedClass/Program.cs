using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedClass
{
    //creating a sealed class
    sealed class Student
    {
        public void showdata()
        {
            Console.WriteLine("hello from student ");
        }
    }
    //derived class cannot be created as base class is sealed class
    //class Engineer : Student
    //{
        //public void showdata()
        //{
          //  Console.WriteLine("hello");
        //}
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(); 
            s.showdata();
            Console.ReadLine();
        }
    }
}
