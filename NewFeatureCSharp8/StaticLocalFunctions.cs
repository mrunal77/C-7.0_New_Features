using System;

namespace StaticLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo with regular local function:");
            RegularLocalFunction();

            Console.WriteLine("\nDemo with static local function:");
            StaticLocalFunction();
        }

        // Example of a regular local function that can capture variables from the enclosing scope
        static void RegularLocalFunction()
        {
            int capturedVariable = 5;

            // Local function that captures the above variable
            int AddCapturedValue(int number)
            {
                return number + capturedVariable;
            }

            int result = AddCapturedValue(10);
            Console.WriteLine($"Result (Regular): {result}");
        }

        // Example of a static local function that does NOT capture variables from the enclosing scope
        static void StaticLocalFunction()
        {
            int staticVariable = 10;

            // Static local function that cannot capture the enclosing scope's variables
            static int AddValues(int number1, int number2)
            {
                return number1 + number2;
            }

            // You must pass any needed values explicitly to the static local function
            int result = AddValues(20, staticVariable);
            Console.WriteLine($"Result (Static): {result}");
        }
    }
}
