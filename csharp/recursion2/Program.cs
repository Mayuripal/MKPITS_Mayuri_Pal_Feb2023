using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion2
{
    class Program
    {
        static int myfunct(int x,int y)
        {
            if (y <= 0)
            { 
            return 1;
            }
            else
            {
                return x *myfunct(x,y-1);
            }
        }
        static void Main(string[] args)
        {
            int res = myfunct(5, 3);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
