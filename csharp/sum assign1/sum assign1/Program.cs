using System;


namespace sum_assign1
{
    class Program
    {
        static void Main()
        {
            int num1, num2, result;
            Console.WriteLine("enter number 1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2=Convert.ToInt32(Console.ReadLine());
             result = calculatesum(num1,num2);
            Console.WriteLine("sum =" + result);
            Console.ReadKey();
        }
        static int calculatesum(int n1,int n2) 
        {
            int sum = n1 +n2 ;
            return sum ;
        }
    }
}
