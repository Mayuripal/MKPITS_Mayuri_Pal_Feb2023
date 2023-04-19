using System;


namespace Arraysort
{
    class Program
    {
        static void Main()
        {
            //creating a new array
            int[] num = { 5,3, 9, 1, 2, 4, 6 };
            Array.Sort(num);

            //display the value
            for(int i=0; i<num.Length; i++)
            {
                Console.WriteLine(num[i]+"\t");
            }
            Console.ReadLine();
        }
    }
}
