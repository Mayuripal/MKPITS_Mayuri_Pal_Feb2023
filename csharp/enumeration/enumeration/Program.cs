using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration
{
    //making an enumerator grade
    enum grade
    {
        //following are the data members
        A=90, B=60, C=40
    }
    class Program
    {
        static void Main(string[] args)
        {
            //getting the integer value of data member

            Console.WriteLine("Ria got "+(int)grade.A);
            Console.ReadLine();
        }
    }
}
