using System;


namespace float_array
{
    class Program
    {
        static void Main()
        {
            float [] arr = new float [10];
            arr[0] = 1.34f;
            arr[1] = 2.4f;
            arr[2] = 3.67f;
            arr[3] = 4.5f;
            arr[4] = 5.23f;
            arr[5] = 6.92f;
            arr[6] = 7.5f;
            arr[7] = 8.59f;
            arr[8] = 9.02f;
            arr[9] = 10.12f;
            //display the array element
            foreach (float val in arr)
            {
                Console.WriteLine("num =" + val);
            }
            Console.ReadLine();
        }
    }
}
