using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short i = 2;
            object o = i;
            sbyte q = (sbyte)(short)o;
            Console.WriteLine("{0} = {1}", q,q.GetType());
        }
    }
}
