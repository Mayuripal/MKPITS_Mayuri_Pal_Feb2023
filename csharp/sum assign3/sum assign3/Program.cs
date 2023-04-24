using System;


namespace sum_assign3
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = calculate(arr);
            Console.WriteLine("sum is "+result);
            Console.ReadLine();

        }
        static int calculate(int[] arr1) 
        {
            int sum = 0;
            for(int i=0; i<arr1.Length; i++)
            { 
                sum =sum +i;
            }
            return sum;
        }
    }
}
