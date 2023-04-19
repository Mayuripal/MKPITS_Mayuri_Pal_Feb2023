using System;


namespace methodprog_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());


            calculateprime(num);
            
            Console.ReadKey();
        }
        static void calculateprime(int n1)
        {
            int counter = 2;
            if (n1%2==0)
            {
                Console.WriteLine("it is not prime number");
                
            }
            else
            {
                Console.WriteLine("it is a prime no. ");
                   
            }
            counter++;
        }

    }
}  
