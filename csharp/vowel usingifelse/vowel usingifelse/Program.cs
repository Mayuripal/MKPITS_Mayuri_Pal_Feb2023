using System;


namespace vowel_usingifelse
{
    class Program
    {
        static void Main()
        {
            char check;
            Console.WriteLine("enter character");
            check=Convert.ToChar(Console.ReadLine());
            if (check == 'a'||check=='e'||check=='i' || check == 'o' || check == 'u')
            {
                Console.WriteLine("this is vowel");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("this is a consonant");
                Console.ReadLine();
            }
        }
    }
}
