using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatureCSharp7
{
    class BinaryLiteralsDemo
    {
        static void Main()
        {
            var i = 0b1000010;
            Console.WriteLine("Value is: " + (char)i);
            Console.WriteLine(i.GetType());

            Console.ReadLine();
        }
    }
}
