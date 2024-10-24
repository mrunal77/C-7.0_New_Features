using System;
using System.Collections.Generic;

namespace NullCoalescingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Null-coalescing assignment with a string
            string? name = null;

            // Before C# 8: Using traditional null check and assignment
            if (name == null)
            {
                name = "John Doe";
            }
            Console.WriteLine($"Name after traditional null-check: {name}");

            // C# 8: Using null-coalescing assignment operator (??=)
            name ??= "Jane Doe";
            Console.WriteLine($"Name after null-coalescing assignment: {name}");

            // Example 2: Null-coalescing assignment with a List<int>
            List<int>? numbers = null;

            // Before C# 8: Using traditional null check and assignment
            if (numbers == null)
            {
                numbers = new List<int>();
            }
            numbers.Add(1);
            Console.WriteLine("\nNumbers after traditional null-check and assignment:");
            numbers.ForEach(num => Console.WriteLine(num));

            // C# 8: Using null-coalescing assignment operator (??=)
            numbers ??= new List<int>();
            numbers.Add(2);
            Console.WriteLine("\nNumbers after null-coalescing assignment:");
            numbers.ForEach(num => Console.WriteLine(num));
        }
    }
}
