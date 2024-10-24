using System;

namespace ReadonlyMembers
{
    struct Point
    {
        // Readonly fields
        public readonly int X;
        public readonly int Y;

        // Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Readonly property: Guarantees that this property doesn't modify the struct
        public readonly double DistanceFromOrigin => Math.Sqrt(X * X + Y * Y);

        // Readonly method: This method is marked as readonly, so it cannot modify the struct
        public readonly void DisplayCoordinates()
        {
            // This method can read fields but cannot modify them
            Console.WriteLine($"Point ({X}, {Y})");
        }

        // Non-readonly method: This method is allowed to modify the struct
        public void Move(int dx, int dy)
        {
            // Since this is a non-readonly method, we can modify the fields
            // BUT in this example, it's not practical because structs are value types
            // and a copy is passed when modifying within a method.
            this = new Point(X + dx, Y + dy);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Readonly Members in C# 8:");

            Point p = new Point(3, 4);

            // Calling a readonly method that will not modify the struct
            p.DisplayCoordinates();
            Console.WriteLine($"Distance from origin: {p.DistanceFromOrigin}");

            // Move the point (Non-readonly method)
            p.Move(1, 2);
            p.DisplayCoordinates(); // Displays the modified coordinates
        }
    }
}
