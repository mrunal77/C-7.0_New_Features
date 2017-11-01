using System;

namespace NewFeatureCSharp7
{
    class TuplesDemo1
    {
        public (int, int) Math2(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);              
        }

        public static void Main()
        {
            TuplesDemo1 d = new TuplesDemo1();
            (int, int) obj = d.Math2(10, 30);

            Console.WriteLine(obj.Item1);
            Console.WriteLine(obj.Item2);
            Console.ReadLine();
        }
    }
}
