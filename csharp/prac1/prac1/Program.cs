using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1
{
    using System;

    public class MyClass
    {
        public int publicField;

        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass myObject = new MyClass();
            myObject.publicField = 10;     // Accessible outside the class
            myObject.PublicMethod();       // Accessible outside the class
        }
    }

    
}
