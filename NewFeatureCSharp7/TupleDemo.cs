using System;

namespace NewFeatureCSharp7
{
    class TupleDemo
    {
        public Tuple<int,int> Math1(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            Tuple<int,int> t=Tuple.Create(c, d);
            return t;
        }
        public static void Main()
        {
            TupleDemo demo = new TupleDemo();
            Tuple<int, int> t1 = demo.Math1(10,30);

            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item2);
            Console.Read();
        }
    }
}
