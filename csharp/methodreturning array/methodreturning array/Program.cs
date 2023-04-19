using System;

namespace methodreturning_array
{
    class Program
    {
        static int[] returnarray()
        {
            int[] a = { 21,72, 63 };

            return a;
        }

        static void Main()
        {
            int[] arr =returnarray();
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
