using System;

namespace PatternMatching
{
    // Define a base Shape class
    public abstract class Shape
    {
        public abstract string Name { get; }
    }

    // Derived class Circle
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius) => Radius = radius;
        public override string Name => "Circle";
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override string Name => "Rectangle";
    }

    // Derived class Triangle
    public class Triangle : Shape
    {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
        public override string Name => "Triangle";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle(5);
            Shape shape2 = new Rectangle(4, 5);
            Shape shape3 = new Triangle(3, 4);

            Console.WriteLine(CalculateArea(shape1));  // Circle
            Console.WriteLine(CalculateArea(shape2));  // Rectangle
            Console.WriteLine(CalculateArea(shape3));  // Triangle
        }

        // Method using switch expressions and pattern matching
        static string CalculateArea(Shape shape) => shape switch
        {
            // Property pattern for Circle
            Circle { Radius: var r } => $"Area of {shape.Name}: {Math.PI * r * r:F2}",

            // Property pattern for Rectangle
            Rectangle { Width: var w, Height: var h } => $"Area of {shape.Name}: {w * h}",

            // Positional pattern for Triangle
            Triangle { Base: var b, Height: var h } => $"Area of {shape.Name}: {0.5 * b * h}",

            // Default case
            _ => "Unknown shape"
        };
    }
}
