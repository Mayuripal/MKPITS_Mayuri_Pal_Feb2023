using System;


namespace clearmethod
{
    class Program
    {
        static void Main()
        {
            //creating a array
            int[] num = { 4, 9, 2, 5, 2, 8, 4 };
            Array.Clear(num, 0, 3);

            //display the value of array
            for(int i=0; i<num.Length; i++)
            {
                Console.WriteLine(num[i]+"\t");
            }
            Console.ReadLine();
        }
    }
}
