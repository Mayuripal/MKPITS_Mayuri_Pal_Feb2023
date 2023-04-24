using System;


namespace primenumusing_nestedfor
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int outercounter = 1; outercounter <= 20; outercounter++)
            {
                int num = outercounter;
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
                if (isprime == 0)
                {
                    Console.WriteLine(num+"it is prime no.");
                    Console.ReadLine();

                }

            }
        }
    }
}

