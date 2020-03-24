using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[13];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(51);
            }

            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
        }
    }
}
