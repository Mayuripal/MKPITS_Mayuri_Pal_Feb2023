using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerationMonth
{
    //making an enumeration month
    enum month
    {
        //folling are the data members
        jan=1,feb,mar,april,may
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //getting the integer value of data members
            Console.WriteLine("Jan month is " + (int)month.jan);
            Console.WriteLine("Mar month is " + (int)month.mar);
            Console.WriteLine("May month is " + (int)month.may);

            Console.ReadLine();
        }
    }
}
