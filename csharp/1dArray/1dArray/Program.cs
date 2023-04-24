using System;

namespace _1dArray
{
    class Program
    {
        static void Main()
        {
            int[] num = new int[5];
            for(int row=0; row<5; row++) 
            {
                Console.WriteLine("enter number");
                num[row] = Convert.ToInt32(Console.ReadLine());

            }
            //display the value of array
            for(int row=0; row<5;row++)
            {
                Console.WriteLine("num[{0}]={1}", row, num[row]);
            }
            Console.ReadLine();

        }
    }
}
