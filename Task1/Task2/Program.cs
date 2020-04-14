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

            int a = (int)arr[0];
            a += 10;
            arr[0] = a;
            arr[2] += ", guys!";

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
