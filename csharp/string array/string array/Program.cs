using System;


namespace string_array
{
    class Program
    {
        static void Main()
        {
            string [] arr = new string[5];
            arr[0] = "amit";
            arr[1] = "anu";
            arr[2] = "riya";
            arr[3] = "tina";
            arr[4] = "piya";
            
            //display the array element
            foreach (string val in arr)
            {
                Console.WriteLine("num =" + val);
            }
            Console.ReadLine();
        }
    }
}
