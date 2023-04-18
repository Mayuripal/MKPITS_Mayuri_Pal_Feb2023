using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tableoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = tab(5,1);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        static int tab(int a, int b) 
        {  
            if(b <=10)
            {
                return 1;
            }
            else
            {
                return a *tab(a, b++);
            }
        }
    }
}
