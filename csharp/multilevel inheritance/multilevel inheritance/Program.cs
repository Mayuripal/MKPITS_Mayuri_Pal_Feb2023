using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance
{
    public class animal
    {
        public void eat()
        {
            Console.WriteLine("eating....");
        }
    }
    public class dog:animal
    {
        public void bark()
        {
            Console.WriteLine("barking....");
        }
    }
    public class pup : dog
    {
        public void weep()
        {
            Console.WriteLine("weeping.....");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            pup d1= new pup();
            d1.eat();
            d1.bark();
            d1.weep();
            Console.ReadLine();

        }
    }
}
