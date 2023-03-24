using System;


namespace vowel
{
    class Program
    {
        static void Main()
        {
            char op;
            Console.WriteLine("enter a char ");
            op=Convert.ToChar(Console.ReadLine());
            switch (op) 
            {
                case'a':
                    Console.WriteLine("vovel");
                    Console.ReadLine();
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    Console.ReadLine();
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    Console.ReadLine();
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    Console.ReadLine();
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("consonant");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
