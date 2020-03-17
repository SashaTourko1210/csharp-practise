using System;

namespace Lect5.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = DateTime.Now.Hour;

            if (h>=9 && h<=12)
            {
                Console.WriteLine("Good morning, guys!");
            }
            else if (h>12 && h<=15)
            {
                Console.WriteLine("Good day,guys!");
            }
            else if (h>15 && h<=22)
            {
                Console.WriteLine("Good night, guys!");
            }


        }
    }
}
