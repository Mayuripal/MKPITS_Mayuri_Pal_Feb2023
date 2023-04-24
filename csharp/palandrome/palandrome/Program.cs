using System;
using System.CodeDom;

namespace palindrome
{
    class Program
    {
        static void Main()
        {
            string s;
            Console.WriteLine(" Enter string");
            s= Console.ReadLine();
            string result = calculateword(s);
            Console.WriteLine("palandrome " + result);
            Console.ReadLine();
        }
        static string calculateword (string b)
        {
            string  revs = "";
            for (int i = b.Length - 1; i >= 0; i--)
            {
                revs += b[i].ToString();

            }
            if(revs == b)
                {
                    
                }
                else 
                {
                    Console.WriteLine("is not palandrome");
                   
                }
                return revs;
            
        }
    }
}