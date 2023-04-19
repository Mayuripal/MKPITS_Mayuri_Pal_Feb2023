using System;


namespace getlength_method
{
    class Program
    {
        static void Main()
        {
            //creating an array
            int[] num = { 3, 5, 6, 7, 8, 9, 10 };
            int l=num.GetLength(0);
            Console.WriteLine("length "+l);
            Console.ReadLine();
        }
       

    }
}
