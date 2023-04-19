using System;


namespace multiplying_matrix
{
    class Program
    {
        static void Main()
        {
            int[,] arr1 = { { 1, 2 }, { 3, 4 } };
            int[,] arr2 = { { 11, 22 }, { 33, 44 } };
           //arr3 to store value after multiplication
            int[,] arr3 = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr3[i, j] = arr1[i, j] * arr2[i, j];
                }
            }

            //display value
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
