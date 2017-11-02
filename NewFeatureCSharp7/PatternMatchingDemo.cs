using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatureCSharp7
{
    public class Figure
    {
        public const float pi = 3.14f;
    }

    public class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }
    }

    class PatternMatchingDemo
    {
        public static void PrintArea( Figure f)
        {
            //Before C# 7.0
            //if(f is Rectangle)
            //{
            //    Rectangle rect= f as Rectangle;
            //    Console.WriteLine("Area of Rectangle:" + rect.Width * rect.Height);
            //}
            //else if(f is Circle)
            //{
            //    Circle circ = f as Circle;
            //    Console.WriteLine("Area of Circle:" + Circle.pi * circ.Radius * circ.Radius);
            //}

            //After C# 7.0
            //if (f is Rectangle rect)
            //    Console.WriteLine("Area of Rectangle: " + rect.Height * rect.Width);
            //else if (f is Circle circ)
            //    Console.WriteLine("Area of Circle: " + Circle.pi * circ.Radius * circ.Radius);

            //Switch case
            switch(f)
            {
                case Rectangle rect when rect.Height == rect.Height:
                    Console.WriteLine("Area of Square:" + rect.Width * rect.Height);
                    break;
                case Rectangle rect:
                    Console.WriteLine("Area of Rectangle:" + rect.Width * rect.Height);
                    break;

                case Circle circ:
                    Console.WriteLine("Area of Circle: " + Circle.pi * circ.Radius * circ.Radius);
                    break;
            }
        }
        static void Main()
        {
            Rectangle r1 = new Rectangle { Width = 12.34, Height = 56.78 };
            Rectangle r2 = new Rectangle { Width = 56.72, Height = 56.72 };
            Circle c = new Circle { Radius = 34.56 };

            PrintArea(r1);
            PrintArea(r2);
            PrintArea(c);

            Console.Read();
        }
    }
}
