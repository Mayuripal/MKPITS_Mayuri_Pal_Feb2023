using System;
using System.Globalization;

namespace transpose_ofmatrix
{
    class Program
    {
        static void Main()
        {
            int[,] arr1 = {{ 1, 2, 3 },{ 4,5,6},{ 7,8,9} };

            int[,] arr2 = new int[3, 3];
            for (int i = 0; i < 3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i, j] = arr1[i,j];
                }
            }

            for(int i = 0;i < 3;i++) 
            {
                for(int j = 0;j < 3;j++)
                {
                    Console.Write(arr1[i,j]+"\t");
                }
                Console.WriteLine();
            }


            

            Console.ReadLine();

        }
       
    }
}
