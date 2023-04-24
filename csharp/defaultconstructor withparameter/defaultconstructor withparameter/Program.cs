using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultconstructor_withparameter
{
    class student
    {
        int rno;
        string name;
        //creating a constructor
       
        //creating a constructor with parameter
        public student(int rno,string name)
        {
            this.rno = rno;
            this.name = name;
        }
        public void displaydata()
        {

            Console.WriteLine("rno :" + rno);
            Console.WriteLine("name :" + name);
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();
            // it will call constructor

            stud1.displaydata();

            Console.WriteLine("enter rno");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            student stud2 = new student(rno, name);//will call constructor with parameters
            stud2.displaydata();


        }
    }
}
