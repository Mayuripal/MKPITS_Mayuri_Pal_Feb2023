using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankoverridding
{
    class Account
    {
        public int bal=1000;
        public void deposit(int amt)
        {
            Console.WriteLine("deposite method of account class ");
            Console.ReadLine();
        }
    }
    class Saving :Account
    {
        int intrest = 500;
        public void deposite(int amt)
        {
            bal = bal + amt + intrest;
            Console.WriteLine("balance "+bal);
            Console.ReadLine();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Saving s = new Saving();
            s.deposit(200);
        }
    }
}
