using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=10; 
            int b=0;
            int res = 0;
            try
            {
                res = a / b;
                Console.WriteLine("result " + res);
            }
            catch (DivideByZeroException ee) 
            {
                Console.WriteLine(ee.ToString());
            }
            finally 
            {
                Console.WriteLine("finally excuted"); 
            }
            Console.WriteLine("bye");
        }
    }
}
