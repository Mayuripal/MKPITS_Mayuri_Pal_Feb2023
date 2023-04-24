using System;


namespace clonemethod
{
    class Program
    {
        static void Main()
        {
            //creating an array
            int[] num = {5,2,6,1,4 };

            int[] num1 = (int[])num.Clone();

            //display the values of array
            for(int i=0; i<num1.Length; i++)
            {
                Console.WriteLine(num1[i]+"\t");

            }
          
            Console.ReadLine();

        }
    }
}
