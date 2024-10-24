using System;

namespace DefaultInterfaceMethodsDemo
{
    // Define the interface with a default method implementation
    public interface ILogger
    {
        // Method with a default implementation
        void Log(string message)
        {
            Console.WriteLine($"Default Log: {message}");
        }

        // Abstract method (no implementation, to be overridden)
        void LogError(string error);
    }

    // Class that implements ILogger interface
    public class ConsoleLogger : ILogger
    {
        // Override the abstract method
        public void LogError(string error)
        {
            Console.WriteLine($"Error: {error}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of ConsoleLogger
            ILogger logger = new ConsoleLogger();

            // Call the default method (no override necessary)
            logger.Log("This is a log message.");

            // Call the abstract method (must be implemented by the class)
            logger.LogError("This is an error message.");
        }
    }
}
