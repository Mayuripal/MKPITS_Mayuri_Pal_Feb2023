using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    public class Program
    {
        public static void Main()
        {
            // string collection
            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java language"
            };

            //LINQ Query Syntax
            var result = from s in stringList
                         where s.Contains("Tutorial")
                         select s;

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
