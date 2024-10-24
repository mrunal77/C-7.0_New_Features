using System;

namespace UnmanagedConstructedTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unmanaged Constructed Types in C# 8:");

            // Calling the generic method with unmanaged types
            int[] intArray = { 1, 2, 3, 4, 5 };
            float[] floatArray = { 1.1f, 2.2f, 3.3f, 4.4f };

            Console.WriteLine("Sum of integers: " + SumUnmanagedArray(intArray));
            Console.WriteLine("Sum of floats: " + SumUnmanagedArray(floatArray));

            // Using a struct with unmanaged fields
            Point[] pointsArray = { new Point(1, 2), new Point(3, 4), new Point(5, 6) };
            Console.WriteLine("Sum of points (as unmanaged struct): " + SumUnmanagedArray(pointsArray));
        }

        // Generic method constrained to unmanaged types
        static T SumUnmanagedArray<T>(T[] array) where T : unmanaged
        {
            T sum = default;

            // Sum all elements in the array
            foreach (var item in array)
            {
                sum = Add(sum, item);
            }

            return sum;
        }

        // Helper method to add two unmanaged types (using operator overloading)
        static T Add<T>(T a, T b) where T : unmanaged
        {
            dynamic da = a; // Using dynamic to leverage operator overloading
            dynamic db = b;
            return da + db;
        }
    }

    // Unmanaged struct: Only contains unmanaged types (e.g., int)
    struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public override string ToString() => $"({X}, {Y})";
    }
}
