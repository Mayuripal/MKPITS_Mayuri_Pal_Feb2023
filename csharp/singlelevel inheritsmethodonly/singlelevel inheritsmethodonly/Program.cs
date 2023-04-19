using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlelevel_inheritsmethodonly
{
    public class animal
    {
        public void eat()
        {
            Console.WriteLine("eating...");
        }

        public class dog : animal
        {
            public void bark()
            {
                Console.WriteLine("barking....");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                dog d1 = new dog();
                d1.bark();
                d1.eat();
                Console.ReadLine();
            }
        }
    }
}    

