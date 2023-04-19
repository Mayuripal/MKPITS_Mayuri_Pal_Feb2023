using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_assig5
{
    class order
    {
        string type;
        string item;
        int quantity;
        int rate;
        int total;

        public void getdata()
        {
            type = "southindian";
            item = "dosa";
            quantity = 2;
            rate=60;
            total = 120;
        }
        public void displaydata()
        {
            Console.WriteLine("Order :" + type);
            Console.WriteLine("Dish :" + item);
            Console.WriteLine("price :" + rate); 
            Console.WriteLine("Quantity :" + quantity);
            Console.WriteLine("total :" + total);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            order order1 = new order();
            order1.getdata();
            order1.displaydata();
        }
    }
}
