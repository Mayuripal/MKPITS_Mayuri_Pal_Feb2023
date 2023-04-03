using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [3] ;
            for (int i=0 ; i<arr.Length ; i++)
            {
                Console.WriteLine("enter number :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int temp;

            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length; j++) 
                {
                    if (arr[i] == arr[j])
                    { 
                        temp = arr[i] + arr[j];
                    }
                }
            }

            for (int i=0; i<arr.Length;i++) 
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}
