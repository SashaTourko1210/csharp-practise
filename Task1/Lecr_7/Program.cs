using System;

namespace Lecr_7
{
    class Program
    {

        public static T[] Empty<T>()
        {
            return EmptyArray<T>.Value;
        }

        internal static class EmptyArray<T>
        {
            public static readonly T[] Value = new T[0];
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
