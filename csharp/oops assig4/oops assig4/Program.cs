using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oops_assig4
{
    class car
    {
        string model;
        string colour;
        int engine;
        string fuel;
        float price;
        float mileage;

        public void getdata()
        {
            model ="THAR RWD";
            colour = "black";
            engine= 1497 ;
            fuel = "disel&petrol";
            price = 9.99f;
            mileage = 15.2f;
        }

        public void displaydata()
        {
            Console.WriteLine("car model :"+model);
            Console.WriteLine("car colour :"+colour);
            Console.WriteLine("car engine :"+engine+"cc");
            Console.WriteLine("car fuel type :"+fuel);
            Console.WriteLine("car price :"+price+"lakh");
            Console.WriteLine("car mileage :"+mileage+"kmpl");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.getdata();
            car1.displaydata();
        }
    }
}
