using System;

namespace methodprog_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter no. ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = calculatetable(num);
            Console.WriteLine("table :" + result);
            Console.ReadLine();
        }
        static int calculatetable(int n1)
        {

            int counter = 0;

            int i=1;
            
            while (i <= 10)
            {
                counter = n1 * i;
                Console.WriteLine(counter);
                    i++;

            }
            return counter;
        }
    }
}
