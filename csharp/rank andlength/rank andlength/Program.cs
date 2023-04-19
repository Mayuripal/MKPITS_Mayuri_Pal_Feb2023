using System;


namespace rank_andlength
{
    class Program
    {
        static void Main()
        {
            int[,] num = new int[2, 3];
            for(int i=0;i<2;i++) 
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine("enter num");
                    num[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //display value of array
            for(int i=0;i<2;i++) 
            {
                for(int j = 0;j<3;j++)
                {
                    Console.Write(num[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("rank"+num.Rank);
            Console.WriteLine("length" + num.Length);
            Console.ReadLine();
        }
    }
}
