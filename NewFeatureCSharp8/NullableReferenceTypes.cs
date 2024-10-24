using System;

namespace NullableReferenceTypes
{
    class Program
    {
        // Non-nullable reference type
        static string Greet(string name)
        {
            return $"Hello, {name}!";
        }

        // Nullable reference type
        static string? GetNullableName(bool provideName)
        {
            if (provideName)
            {
                return "Alice";
            }
            else
            {
                return null; // Can return null
            }
        }

        static void Main(string[] args)
        {
            // Non-nullable reference type
            string nonNullableName = "John";  // Must not be null
            Console.WriteLine(Greet(nonNullableName));

            // Uncommenting the following line will cause a compile-time warning:
            // nonNullableName = null;

            // Nullable reference type
            string? nullableName = GetNullableName(false);

            // Compile-time warning: possible dereference of null
            // Uncommenting this will show a warning
            // Console.WriteLine(Greet(nullableName));

            // Correct usage of nullable reference type
            if (nullableName != null)
            {
                Console.WriteLine(Greet(nullableName)); // Safe, since we've checked for null
            }
            else
            {
                Console.WriteLine("Name is null.");
            }
        }
    }
}
