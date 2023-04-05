using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingthis_keyword
{
    class student
    {
        int rno;
        string name;

        public void getdata(int rno,string name)
        {
            this.rno = rno;
            this.name = name;   
        }

        public void displaydata()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("roll no :" + rno);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();
            Console.WriteLine("enter name :");
            string name=Console.ReadLine();
            Console.WriteLine("rnter roll no. :");
            int rno=Convert.ToInt32(Console.ReadLine());

            stud1.getdata(rno,name);
            stud1.displaydata();
        }
    }
}
