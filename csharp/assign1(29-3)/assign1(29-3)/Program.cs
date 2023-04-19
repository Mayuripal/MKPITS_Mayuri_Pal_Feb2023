using System;
using System.Runtime.Remoting.Services;

namespace assign1_29_3_
{
    class Program
    {
        static void Main()
        {
            //create array to store 5 student name
            string[] arr = new string[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("enter student name : ");
                arr[i]=Convert.ToString(Console.ReadLine());
            }

            //display
            for(int i=0;i<5; i++) 
            {
                Console.WriteLine("  "+arr[i]);
            }
            Console.WriteLine(); 
            Console.ReadLine();
        }
    }
}
