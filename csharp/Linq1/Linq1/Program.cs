using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    public class Program
    {
        public static void Main()
        {
            //Data source
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            //LINQ Query
            var myLinkQuery =from name in names
                             where name.Contains('a')
                             select name;

            //Query execution
            foreach (var name in myLinkQuery)
            {
                Console.Write(name + "");
            }
        }
    }
}
