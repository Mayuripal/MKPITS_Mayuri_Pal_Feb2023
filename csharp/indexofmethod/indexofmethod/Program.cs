using System;

namespace indexofmethod
{
    class Program
    {
        static void Main()
        {
            //creating ana array
            int[] num = { 3, 7, 2, 6, 5 };

            int l=Array.IndexOf(num, 6);
            Console.WriteLine("index "+l);
            Console.ReadLine();
        }
    }
}
