using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 3, 2, 5, 1, 7, 7 };
            int sum=0;
            int num = 0;

            //find 2 repeating numbers
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        num = arr[i] = arr[j];
                    }
                    if (arr[i] == arr[j])
                    {

                    }
                }
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
