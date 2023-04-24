using System;
using System.ComponentModel;

namespace method1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("calling the method display");
            display ();
            Console.WriteLine("again calling display");
            display ();

        }
        //creating user defined method diaplay
        static void display()
        { Console.WriteLine("hello world");
        Console.ReadLine(); }
    }
}
