using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b=3;
            int c=2;

            int z = ++a + b + c++;
            Console.WriteLine(z);
            int q = a + b / c - c;

            int x = 1;
            int y = 2;
            //int k = 3;
            float e = ((2 * x) - (4 * y) + 9) ;
            
            Console.WriteLine(q);
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
