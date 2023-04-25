using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticConstructor
{
    public class Calculate
    {
        public static float pi;
        static Calculate ()
        {
            pi = 3.14f;
            Console.WriteLine("static constructor called ");
        }
        public void display()
        {
            Console.WriteLine("rate of intrest " + pi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c1= new Calculate();
            Calculate c2= new Calculate();
            c1.display();
            c2.display();
        }
    }
}
