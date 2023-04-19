using System;

namespace _5_prog
{
     class Program
    {
        static void Main()
        {
            int length, breath, area;
            Console.WriteLine("enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breath");
            breath = Convert.ToInt32(Console.ReadLine());
            area = length+ breath;
            Console.WriteLine("Area of rectangle is " + area);
            Console.ReadKey();
        }
    }
}
