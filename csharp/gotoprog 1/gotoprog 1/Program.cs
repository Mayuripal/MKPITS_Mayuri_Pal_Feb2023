using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace gotoprog_1
{
    class Program
    {
        static void Main()
        {
            int num1, num2, result = 0;
            char op;
            Console.WriteLine("enter num1 ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2 ");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter operator ");
            op =Convert.ToChar(Console.ReadLine()); 

            if(op=='+')
            {
                goto addition;
            }
            else if(op=='-')
                {
                goto subtraction;
            }
            else
            {
                goto end;
            }
        addition:
            result = num1 + num2;
            goto end;
        subtraction:
            result = num1 - num2;
            goto end;
        end:
                Console.WriteLine("result" + result);
                Console.ReadLine();
        }
    }
}
