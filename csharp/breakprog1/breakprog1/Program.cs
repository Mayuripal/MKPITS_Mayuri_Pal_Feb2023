using System;


namespace breakprog1
{
    class Program
    {
        static void Main()
        {
          
            int i= 1;
            for( i = 1; i <=10;i++)
            {
                if(i==5)
                {
                    break;
                }
            Console.WriteLine("counter"+i);
                Console.ReadLine();
            }
        }
    }
}
