using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            myfunct(x);
        }
        static void myfunct(int x) 
        {
            if(x>0)
            {
                Console.WriteLine(x);
                Console.ReadLine();
                myfunct(x-1);
            }
        }
    }
}
