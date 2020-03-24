using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[3] {32, 'A', "Hello"};

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            arr[0] = arr[0] + 10;
            arr[2] = arr[2] + ", guys!";

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
