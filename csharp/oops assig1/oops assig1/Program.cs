using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_assig1
{
    class employee
    {
        int id;
        string name;

        public void getdata()
        {
            id = 100023;
            name = "mayuri";
        }

        public void displaydata()
        {
            Console.WriteLine("Emp.Id :" + id);
            Console.WriteLine("Emp.Name :" + name);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1= new employee();
            emp1.getdata();
            emp1.displaydata();
        }
    }
}
