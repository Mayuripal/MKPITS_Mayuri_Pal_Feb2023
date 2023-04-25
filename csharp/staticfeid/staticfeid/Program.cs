using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfeid
{
    class Account
    {
        public int actno;
        public string name;
        public static float roi = 4.5f;
        public Account(int actno,string name) 
        { 
            this.actno = actno;
            this.name = name;   
        }
        public void display()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Account no. " + actno);
            Console.WriteLine("Rate of Intrest" + roi);
            Console.ReadLine();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(1234312, "neha");
            Account a2 = new Account(6214312, "riya");
            a1.display();
            a2.display();   

        }
    }
}
