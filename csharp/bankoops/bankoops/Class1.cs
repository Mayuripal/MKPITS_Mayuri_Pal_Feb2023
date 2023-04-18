using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankoops
{
    internal class Account
    {
        public int bal = 1000;
        public virtual int deposit(int amt)
        {
            return bal;
        }
    }
    internal class Saving : Account
    {
        public int intrest = 500;
        public override int deposit(int amt)
        {
            bal = bal + amt + intrest;
            return bal;
        }
    }
    internal class Current : Account 
    {
        public override int deposit(int amt)
        {
            bal= bal + amt;
            return bal;
        }
    }
}
