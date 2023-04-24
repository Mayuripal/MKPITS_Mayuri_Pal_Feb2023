using System;

namespace primenumusing_ifelse
{
    class Program
    {
        static void Main()
        {
            int num = 8;
            int counter;
            int isprime = 0;

            for (counter = 2; counter < num; counter++)
            {
                if (num % counter == 0)
                {
                    isprime = 1;
                    break;
                }
            }
                if(isprime == 0)
                {
                    Console.WriteLine("it is prime no.");

                }
                else
                {
                    Console.WriteLine("it is not prime no.");
                }
            Console.ReadLine();
        }
    }
}
