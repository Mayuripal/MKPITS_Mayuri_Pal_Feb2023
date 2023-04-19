using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractbank
{
    abstract class Account
    {
        public int bal = 1000;
        public abstract void deposit(int amt);
        public string showbalance()
        {
            return "bal is " + bal;
        }
    }
    class Saving :Account
    {
        int intrest = 500;
        public override void deposit(int amt)
        {
            bal=bal+amt+intrest;
            Console.WriteLine("deposited balance is :" + bal);
        }
    }
    class Current : Account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("Deposited balance is :" + bal);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("enter amount ");
             amount=Convert.ToInt32(Console.ReadLine());

            Account Acttype;
            Console.WriteLine("enter account type ");
            
        }
    }
}
