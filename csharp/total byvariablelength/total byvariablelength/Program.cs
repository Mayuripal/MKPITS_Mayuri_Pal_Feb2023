using System;


namespace total_byvariablelength
{
    class Program
    {
        static void Main()
        {
            int total;
            total = calculate(3, 5, 7, 8, 9, 10, 11, 12, 13);
            Console.WriteLine("Total ="+total);
            Console.ReadLine();
        }
        static int calculate(params int[] val)
        {
            int counter, total = 0;
            for (counter=0;counter<val.Length;counter++)
            {
                total =total+ val[counter];
            }
            return total;
        }
    }
}
