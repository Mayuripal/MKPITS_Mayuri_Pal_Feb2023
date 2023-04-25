using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static2
{
    class Account
    {
        public int actno;
        public string name;
        public static float roi;
        public static int count;
        public Account(int actno, string name)
        {
            this.actno = actno;
            this.name = name;
            count++;
                
        }
        public void display()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Account no. " + actno);
            Console.WriteLine("Rate of Intrest " + roi);
            Console.ReadLine();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(1234312, "neha");
            Account a2 = new Account(6214312, "riya");
            Account.roi = 33.4f;
            a1.display();
            a2.display();
            Console.WriteLine("no. of object " + Account.count);
            Console.ReadLine();
        }
    }
}
