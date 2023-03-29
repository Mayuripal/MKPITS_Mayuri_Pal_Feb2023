using System;


namespace search_element
{
    class Program
    {
        static void Main()
        {
            Boolean isfound = false;
            int[] arr= { 1, 2, 3 };
            int num;
            Console.WriteLine("enter a number to be search :");
            num=Convert.ToInt32(Console.ReadLine());    
            for (int counter=0; counter<arr.Length; counter++)
            {
                if (arr[counter] == num)
                {
                isfound = true;
                break;
                }
            }
            if (isfound==true)
            {
                Console.WriteLine(num + " found in array");

            }
            else
            {
                Console.WriteLine("not found");
            }
            Console.ReadLine(); 
        }
    }
}
