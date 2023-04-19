using System;

namespace distructor
{
    class employee
    {
        int empno;
        string empname;

        //creating distructor
        ~employee()
        {
            Console.WriteLine("in destructor we write code to clean up operation like closing a file etc");
        }

        public employee(int empno, string empname)
        {
            this.empno = empno;
            this.empname = empname;
        }

        public void display()
        {
            Console.WriteLine("empno :" + empno);
            Console.WriteLine("empname :" + empname);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee(121, "naina");
            emp.display();
            Console.ReadLine();
        }
    }
}
