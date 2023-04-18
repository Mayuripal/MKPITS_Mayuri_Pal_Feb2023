using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumoops
{
    class Program
    {
        public static int Main(string[] args)
        {
            int n1, primeno;
            Console.Write("input any positive number :");
            n1=Convert.ToInt32(Console.ReadLine());
            primeno = checkforprime(n1, n1 / 2);
            //call the function checkforprime

            if(primeno == 1)
            {
                Console.Write("number {0} is prime number. ", n1);
            }
            else
            {
                Console.Write("number {0} is not a prime .",n1);
                return 0;
            }

            static int checkforprime(int n1,int i)
            {
                if(i==1)
                {
                    return 1;
                }
                else
                {
                    if (n1 % i == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return checkforprime(n1,i);
                    }
            }
        }
    }
}
