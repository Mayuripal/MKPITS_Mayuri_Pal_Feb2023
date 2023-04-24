using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class Account
    {
        public int bal = 1000;
        public virtual void deposit(int amt)
        {
            Console.WriteLine(amt);
            Console.ReadLine();
        }

    }
    class Saving:Account
    {
        public int intrest=100;
        public override void deposit(int amt)
        {
            bal= amt+bal+intrest;
            Console.WriteLine(bal);
            Console.ReadLine();
        }
    }
    class Current : Account
    {
        public override void deposit(int amt)
        {
            bal = amt + bal;
            Console.WriteLine(bal);
            Console.ReadLine();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("Enter Amount :");
            amount= Convert.ToInt32(Console.ReadLine());

            //1st account type should be empty 
            Account act = null;
            string acttype;
            Console.WriteLine("Enter Account type");
            acttype = Console.ReadLine();
            if (acttype =="saving")
            {
                act = new Saving();
            }
            else if (acttype=="current")
            {
                act=new Current();
            }
            act.deposit(amount);

        }
    }
}
