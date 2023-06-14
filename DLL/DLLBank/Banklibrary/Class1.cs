using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banklibrary
{
    public class Class1
    {
        int bal = 1000;
        public string Deposit(int amount)
        {
            bal = bal + amount;
            return "Your balance is " + bal.ToString();
        }

        public string Widthdraw(int amount)
        {
            bal = bal - amount;
            return "Your balance is " + bal.ToString();
        }
    }
}
