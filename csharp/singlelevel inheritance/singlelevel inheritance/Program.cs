using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlelevel_inheritance
{
    //creating a base class
    class employee
    {
        protected int salary;

    }
    //creating derived class
    class programmer : employee
    {
        int bonus;
        public void getdata(int salary,int bonus)
        {
            this.salary = salary;
            this.bonus = bonus; 
        }

        public void displaydata()
        {
            Console.WriteLine("salary " + salary);
            Console.WriteLine("bonus " + bonus);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            programmer p =new programmer();
            p.getdata(23400, 5000);
            p.displaydata();    
        }
    }
}
