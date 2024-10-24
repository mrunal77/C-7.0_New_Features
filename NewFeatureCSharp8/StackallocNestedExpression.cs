using System;

namespace StackallocNestedExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stackalloc in nested expressions (C# 8):");

            // Stackalloc in a method argument
            PrintArray(stackalloc int[] { 1, 2, 3, 4, 5 });

            // Stackalloc in a conditional expression
            bool useSmallArray = true;
            Span<int> numbers = useSmallArray ? stackalloc int[3] { 1, 2, 3 } : stackalloc int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Conditional stackalloc:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Stackalloc in an array initializer
            Span<int> initializedArray = stackalloc int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine("Array initialized with stackalloc:");
            foreach (var number in initializedArray)
            {
                Console.WriteLine(number);
            }
        }

        // Method that takes a Span<int> as a parameter (with stackalloc)
        static void PrintArray(Span<int> numbers)
        {
            Console.WriteLine("Array passed to method using stackalloc:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
