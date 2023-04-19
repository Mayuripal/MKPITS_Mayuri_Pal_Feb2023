using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_usingmethod
{
    public class employee
    {
        public float salary = 40000;
    }
    public class programer : employee
    {
        public float bonus = 10000;
    }
    class Program
    {
        static void Main(string[] args)
        {
            programer p=new programer();
            Console.WriteLine("salary :"+p.salary);   
            Console.WriteLine("bonus :"+p.bonus);  
            Console.ReadLine();

        }
    }
}
