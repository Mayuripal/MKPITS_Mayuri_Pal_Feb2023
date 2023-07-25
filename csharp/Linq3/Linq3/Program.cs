using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // string collection
            IList<string> stringList = new List<string>()
            {
                "C# Tutorial",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"
            };

            //LINQ Method Syntax
            var result = stringList.Where(s => s.Contains("Tutorials"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
