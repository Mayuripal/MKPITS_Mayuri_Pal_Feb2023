using System;

namespace methodprog_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter no. ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result=calculatefactorial(num);
            Console.WriteLine("factorial ="+ result);
            Console.ReadLine();
        }
        static int calculatefactorial(int num)
        {
            
            
            
            int fact = 1;
            while (num > 0)
            {
                fact = fact* num;
                num = num - 1;
            }
            return fact;
        }
    }
}
