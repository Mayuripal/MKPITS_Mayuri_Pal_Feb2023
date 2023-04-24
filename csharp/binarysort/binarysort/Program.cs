using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine("enter a number to be search :");
            int target = int.Parse(Console.ReadLine());
            int result = binarysearch(arr, target);

            if (result == -1)
            {
                Console.WriteLine("the number {0} was not found .", target);
            }
            else
            {
                Console.WriteLine("the number {0} was found at index {1} ", target, result);
            }
            Console.ReadLine();

        }

        static int binarysearch(int[] arr, int target)
            {
            int low = 0;
            int high = arr.Length-1;
            
            while(low<= high)
            {
                int middle=(low+high)/2;

                if (arr[middle] == target)
                {
                    return middle;
                }

                else if (arr[middle] < target)
                {
                    low = middle+1;
                }

                else
                {
                    high= middle-1;
                }

            }
            return -1;

        }
    }
}
