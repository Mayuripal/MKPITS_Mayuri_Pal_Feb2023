using System;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;

namespace stringlength_assign2
{
    class Program
    {
        private static string result;

        static void Main()
        {
            string a;
            Console.WriteLine("enter name");
             a = Convert.ToString(Console.ReadLine());
           int length = calculateword(a);
            
            Console.WriteLine("length is "+length);
            Console.ReadLine();
            


        }
        static int calculateword(string name)
        {
            
           int var= name.Length;
            return var;
        } 
         
    }
}
