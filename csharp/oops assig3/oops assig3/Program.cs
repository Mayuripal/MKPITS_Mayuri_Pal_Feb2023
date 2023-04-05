using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_assig3
{
    class customer
    {
        int id;
        int total;
        long number;
        string name;
        string product;

        public void getdata()
        {
            name = "anaya";
            id = 10023001;
            number = 9132743296;
            product = "medicine";
            total = 1203;
        }

        public void displaydata()
        {
            Console.WriteLine("customer name: " +name);
            Console.WriteLine("customer id: " +id);
            Console.WriteLine("customer mob. : " +number);
            Console.WriteLine("customer product: " +product);
            Console.WriteLine("total :" +total);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            customer cust1 = new customer();
            cust1.getdata();
            cust1.displaydata();
        }
    }
}
