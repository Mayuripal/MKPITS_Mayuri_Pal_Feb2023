using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "annaya";
            char result = '\0';
            int ind = 0;
            for(int i=0;i<input.Length;i++)
            {
                bool isrepeated= false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (i != j && input[i] == input[j])
                    {
                        isrepeated = true;
                        break;
                    }

                    if(!isrepeated) 
                    {
                        result = input[i];
                        ind = i;
                        break;
                    }

                }

            }

            if(result !='\0') 
            {
                Console.WriteLine("the non repeating character in string is : "+result);
                Console.WriteLine("the non repeating character index in string is : "+ind);

            }
            else
            {
                Console.WriteLine("their is no non repeating character in the string " + input);

            }
            Console.ReadLine();
        }
    }
}
