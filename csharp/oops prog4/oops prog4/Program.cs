using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_prog4
{
    class employee
    {
        string id;
        string name;    

        public void getdada(string id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public void displaydata()
        {
            Console.WriteLine("Emp. Id :" + id);
            Console.WriteLine("Emp. name :" + name);
            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee();
            Console.WriteLine("Emp. Id :");
            string id=Console.ReadLine();
            Console.WriteLine("Emp. Name :");
            string name=Console.ReadLine();

            emp1.getdada(id,name);  
            emp1.displaydata();
        }
    }
}
