using System;

namespace _6_prog
{
    class Program
    {
        static void Main()
        {
            string name, course;
            double mobile;
            int rollno,age;

            Console.WriteLine("Enter name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter courses :");
            course   = Console.ReadLine();

            Console.WriteLine("Enter roll no. :");
            rollno= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age :");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter mobile no. :");
            mobile = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Roll no. :" + rollno);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Course :" + course);
            Console.WriteLine("Mobile no. :" + mobile);
            Console.ReadKey();
        }
    }
}
