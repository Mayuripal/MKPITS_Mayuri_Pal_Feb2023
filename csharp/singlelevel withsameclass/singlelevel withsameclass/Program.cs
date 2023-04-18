using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace singlelevel_withsameclass
{
    class person
    {
        string name;
        string address;
        public void getdata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("address :" + address);
        }

        class customer : person
        {
            int custid;
            public void getdata(int custid,string name,string address)
            {
                
                this.custid = custid;
                getdata(name, address);
            }
            public void display()
            {
                base.display();
                Console.WriteLine("cust id :" + custid);
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                customer c = new customer();
                c.getdata(12,"ria","nagpur");
                c.display();
                Console.ReadLine();
            }
        }
    }
}

