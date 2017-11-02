using System;
using System.Collections.Generic;

namespace NewFeatureCSharp7
{
    class LocalFunctionDemo
    {
        static void Main()
        {
            void method(int a, int b)
            {
                Console.WriteLine(a * b);
            }
            method(10, 20);
            method(30, 60);

            void method1(int a, int b, ref int c, ref int d)
            {
                c = a + b;
                d = a * b;
            }
            int r1 = 0, r2 = 0;
            method1(10, 2, ref r1, ref r2);
            Console.WriteLine(r1 + " " + r2);

            void method2(int a, int b, out int c, out int d)
            {
                c = a + b;
                d = a * b;
            }
            int p = 0, q = 0;
            method2(12, 13, out p, out q);
            Console.WriteLine(p + " " + q);

            void method3<T>(T a, T b)
            {
                dynamic l1 = a;
                dynamic l2 = b;
                Console.WriteLine(l1 + l2);
            }

            method3<int>(10, 20);
            method3<string>("Hello","World");
            method3<double>(10.5, 16.9);

            Console.ReadLine();
        }
    }
}
