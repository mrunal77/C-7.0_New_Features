using System;

namespace NewFeatureCSharp7
{
    class DemoOutParameter
    {
        public void Math2(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a * b;
        }

        public static void Main()
        {
            int x=0, y=0;

            DemoOutParameter Opar = new DemoOutParameter();
            Opar.Math2(10,30,out x, out y);

            Console.WriteLine("Add:" + x + "\n" + "Mul:" + y);
            Console.Read();
        }
    }
}
