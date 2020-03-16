using System;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();

            //int
            arraylist.Add(45);//true,boxing
            
            //bool
            arraylist.Add(true);//true,boxing

            //string
            arraylist.Add("Hello!");//false

            //float
            arraylist.Add(23.45);//true, boxing
        }
    }
}
