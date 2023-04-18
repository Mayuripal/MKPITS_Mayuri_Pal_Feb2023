using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact, num;
            //take input from number
            Console.WriteLine("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());

            Program obj = new Program();
            //calling recursive function
            fact = obj.factorial(num);
            Console.WriteLine("factorial of{0} is{1} ", num, fact);
            Console.ReadLine();
        }

        //recursive function
        public int factorial(int num)
        {
            //termination condition
            if (num == 0)
            {
                return 1;
            }
            else 
            //recursive call
            {
                return num * factorial(num - 1);
            }
        }
    }


    
}
