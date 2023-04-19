using System;

namespace primebyreturn_value
{
    class Program
    {
        static void Main()
        {
            int num,result;
            Console.WriteLine("enter number ");
            num=Convert.ToInt32(Console.ReadLine());
            result = calculate(num);
            Console.WriteLine("is prime"+result);
            Console.ReadLine();
        }
        static int calculate(int num1)
        {
            int counter;
            int isprime = 0;
            for(counter = 2; counter < num1; counter++) 
            {
                if(num1%counter ==0) 
                {   
                    isprime=1; break;
                }
                if(isprime==0) 
                {
                    
                }
                else 
                {
                    Console.WriteLine("not a prime");
                }
            }
            return ;
        }
    }
}
