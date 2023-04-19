using System;

namespace method6
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("calling addition method");
            addition(num1, num2);
            Console.WriteLine("calling subtraction method");
            subtraction(num1, num2);
            Console.ReadLine();
        }
        static void addition(int num1, int num2)
         {
            int result = num1 + num2;
            Console.WriteLine("addition is"+result);
          }
        static void subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("subtraction is" + result);
        }


    }
}
