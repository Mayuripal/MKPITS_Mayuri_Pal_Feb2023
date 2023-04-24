using System;


namespace addition_of2Array
{
    class Program
    {
        static void Main()
        {
            int[,] arr1 = { {1,4 }, {5,3} };
            int[,] arr2 = { { 3, 9 }, { 2, 6 } };
            int[,] arr3 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];


                }
            }

            for(int i = 0;i < 2; i++)
            {
                for(int j = 0;j < 2; j++)
                {
                    Console.Write(arr3[i, j]+"\t");                                                                      
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
