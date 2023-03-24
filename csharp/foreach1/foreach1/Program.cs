using System;


namespace foreach1
{
    class Program
    {
        static void Main()
        {
            string[] name = { "amit", "ajay", "aarti" };
            foreach(string val in name )
            {
                Console.WriteLine("name"+val);
                Console.ReadLine();
            }
        }
    }
}
