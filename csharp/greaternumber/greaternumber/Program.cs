using System;


namespace greaternumber
{
     class Program
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            num2 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            num3 =Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num 1 is greater");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("num2 is greater");
            }
            else
            {
                Console.WriteLine("num3 is greater ");
            }
            Console.ReadLine();
        }

    }
}
