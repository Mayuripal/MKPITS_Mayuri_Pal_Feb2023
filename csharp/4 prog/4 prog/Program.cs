using System;

namespace _4_prog
{
    class Program
    {
        static void Main()
        {
            int num1, num2, sum;
            Console.WriteLine("enter num 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Sum of 2 number is " + sum);
            Console.ReadKey();
        }
    }
}
