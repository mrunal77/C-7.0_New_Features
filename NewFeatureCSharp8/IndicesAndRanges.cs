using System;

namespace IndicesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indices and Ranges in C# 8:");

            // Example with an array
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };

            Console.WriteLine("Array: " + string.Join(", ", numbers));

            // Accessing elements using Index
            int lastNumber = numbers[^1];   // Last element (70)
            int secondToLastNumber = numbers[^2];  // Second-to-last element (60)

            Console.WriteLine($"Last number: {lastNumber}");
            Console.WriteLine($"Second-to-last number: {secondToLastNumber}");

            // Accessing a range of elements using Range
            int[] firstThreeNumbers = numbers[0..3];   // First three elements (10, 20, 30)
            int[] middleNumbers = numbers[2..5];       // Elements from index 2 to 4 (30, 40, 50)
            int[] allButFirstAndLast = numbers[1..^1]; // All but the first and last elements (20, 30, 40, 50, 60)

            Console.WriteLine("First three numbers: " + string.Join(", ", firstThreeNumbers));
            Console.WriteLine("Middle numbers: " + string.Join(", ", middleNumbers));
            Console.WriteLine("All but first and last: " + string.Join(", ", allButFirstAndLast));

            // Example with a string
            string sentence = "Hello, World!";
            Console.WriteLine("\nString: " + sentence);

            // Using Index to get characters from the end of the string
            char lastChar = sentence[^1]; // Last character ('!')
            char secondToLastChar = sentence[^2]; // Second-to-last character ('d')

            Console.WriteLine($"Last character: {lastChar}");
            Console.WriteLine($"Second-to-last character: {secondToLastChar}");

            // Using Range to slice the string
            string firstWord = sentence[0..5];  // "Hello"
            string lastWord = sentence[7..^1];  // "World"

            Console.WriteLine($"First word: {firstWord}");
            Console.WriteLine($"Last word: {lastWord}");
        }
    }
}
