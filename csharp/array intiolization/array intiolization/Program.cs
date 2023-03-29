using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_intiolization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a num array of 5 elements
            int[] num = { 1, 2, 3, 4, 5 };

            //display the values of array
            for(int row=0; row<num.Length; row++)
            {
                Console.WriteLine("num[{0}]={1}", row, num[row]);
            }
            Console.ReadLine();
        }
    }
}
