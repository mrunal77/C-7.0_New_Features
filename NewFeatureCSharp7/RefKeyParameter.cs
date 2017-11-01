using System;

namespace NewFeatureCSharp7
{
    class RefKeyParameter
    {
        public void Math1(int x, int y, ref int r1, ref int r2)
        {
            r1 = x + y;
            r2 = x * y;
        }
        static void Main(string[] args)
        {
            RefKeyParameter t1 = new RefKeyParameter();
            int a=0, b=0;
            t1.Math1(8,20,ref a,ref b);
            Console.WriteLine("Add:"+a+"\n"+"Mul:"+b);
            Console.ReadLine();
        }
    }
}
