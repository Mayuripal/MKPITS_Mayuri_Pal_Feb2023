using System;


namespace _7_PROG
{
    class Program
    {
        static void Main()
        {
            int num1,num2,num3,sum;
            Console.WriteLine("please enter no.:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            sum=num1 + num2+num3;
            Console.WriteLine("Addition of 3 no :" + sum);
            Console.ReadKey();
        }
    }
}
