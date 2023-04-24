using System;


namespace total_andgrade
{
    class Program
    {
        static void Main()
        {
            //create array to store 5 student name
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter subject marks : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //display
            int total;
            float per;
            
            {
                total = arr[0] + arr[1] + arr[2];
                Console.WriteLine("Total marks :"+total);
                per = (total / 300f)*100;
                Console.WriteLine("percentage :" + per);
                if(per>80)
                { Console.WriteLine("grade:A"); }
                else if (per>60 && per<80)
                { Console.WriteLine("grade :B"); }
                else { Console.WriteLine("grade :C"); }
            }
            
            Console.ReadLine();
        }
    }
}
