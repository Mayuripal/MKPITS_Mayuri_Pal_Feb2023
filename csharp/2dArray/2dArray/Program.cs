using System;

namespace _2dArray
{
    class Program
    {
        static void Main()
        {
            int[,] arr = new int[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    //store the value
                    Console.WriteLine("enter number ");
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            } 
            //display the value
            for(int row = 0;row < 3; row++) 
            {
                for(int col = 0;col < 3; col++) 
                {
                    Console.Write(arr[row, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
