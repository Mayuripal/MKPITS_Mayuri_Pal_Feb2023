using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IAccount
    {
        string deposit(int amt);
    }
    abstract class Account:IAccount
    {
        public int bal=1000;
        public abstract string deposit(int amt);
        public string showbalance()
        {
            return "bal is " + bal.ToString();
        }
    }
    class Saving:Account 
    {
        int intrest = 500;
        public override string deposit(int amt)
        {
            bal = bal + amt + intrest;
            return "saving account balance is :" + bal;
            
        }
    }
    class Current:Account 
    { 
        public override string deposit(int amt)
        {
            bal=bal + amt;
           return"current account balance is :" + bal;
            
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            //user input value and account type
            Account act = null;
            string acttype;
            Console.WriteLine("enter account type :");
            acttype = Console.ReadLine();
            Console.WriteLine("enter amount : ");
            int amount=Convert.ToInt32(Console.ReadLine());

            if(acttype=="saving")
            {
                act=new Saving();
            }
            else if (acttype=="current")
            {
                act=new Current();
            }
            string res = act.deposit(amount);
            Console.WriteLine(res);
            Console.WriteLine(act.showbalance());
            Console.ReadLine();
        }
      
    }
}
