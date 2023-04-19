using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_assig2
{
    class product
    {
        int rate;
        string name;
        string comp;

        public void getdata()
        {
            name = "Airconditioner";
            comp = "LG";
            rate = 42000;
        }
        public void displaydata()
        {
            Console.WriteLine("product :" + name);
            Console.WriteLine("company :" + comp);
            Console.WriteLine("rate :" + rate);
            Console.ReadLine();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product prod1 = new product();
            prod1.getdata();
            prod1.displaydata();
        }
    }
}
