using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class person
    {
        public string name;
        public string address;

        public void getpersnoldata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersnoldata()
        {
            Console.WriteLine("emp name :" + name);
            Console.WriteLine("emp address :" + address);
            Console.ReadLine();
        }

        class employee : person
        {
            public int id;
            public int salary;

            public void getemployeedata(int id, int salary)
            {
                this.id = id;
                this.salary = salary;
            }
            public void displayemployeedata()
            {
                Console.WriteLine("emp id : " + id);
                Console.WriteLine("salary : " + salary);

            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                employee emp = new employee();
                emp.getpersnoldata("amit", "sadar");
                emp.getemployeedata(333, 9999);
                emp.displayemployeedata();
                emp.displaypersnoldata();


            }
        }
    }
}


