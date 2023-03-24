using System;


namespace method5
{
    class Program
    {
        static void Main()
        {
            calculate();
        }
        static void calculate()
        {
            int num1, num2, result;
            Console.WriteLine("enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("calling addition method");
            result = addition(num1, num2);
            Console.WriteLine("addition" + result);
            Console.WriteLine("calling subtraction method");
            result = subtraction(num1, num2);
            Console.WriteLine("subtraction" + result);
            Console.ReadLine();
        }
        static int addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static int subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
    }
}
