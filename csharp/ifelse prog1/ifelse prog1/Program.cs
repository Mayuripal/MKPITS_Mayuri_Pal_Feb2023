using System;

namespace ifelse_prog1
{
   class Program
    {
        static void Main()
        {
            int age;
            Console.WriteLine("enter age");
            age=Convert.ToInt32(Console.ReadLine());
            if(age <18)
            {
                Console.WriteLine("not eligible to vote");
            }
            else
            {
                Console.WriteLine("eligible to vote");
            }
            Console.ReadLine();
        }
    }
}
