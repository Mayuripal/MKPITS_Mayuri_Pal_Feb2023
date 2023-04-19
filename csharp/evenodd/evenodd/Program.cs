using System;


namespace evenodd

{
    class Program
    {
        static void Main()
        {
            int num;
            Console.WriteLine("enter number ");
            num=Convert.ToInt32(Console.ReadLine());    
            if(num%2==0) 
            {
                Console.WriteLine("no. is even ");
            }
            else 
            {
                Console.WriteLine("no. is odd");
            }
            Console.ReadLine();
        }
    }
}
