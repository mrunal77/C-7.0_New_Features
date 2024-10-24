using System;

namespace UsingDeclarations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo with traditional using block:");

            // Traditional using block
            using (var resource = new DemoResource("Traditional Using Block"))
            {
                resource.PerformOperation();
            } // Resource is disposed here when the using block ends

            Console.WriteLine("\nDemo with using declaration:");

            // Using declaration: resource will be disposed at the end of the scope (method exit)
            var resource2 = new DemoResource("Using Declaration");
            resource2.PerformOperation();
            // No need for explicit using block. resource2 will be disposed automatically when it goes out of scope.
        }
    }

    // Simulate a resource that implements IDisposable
    public class DemoResource : IDisposable
    {
        private string _resourceName;

        public DemoResource(string resourceName)
        {
            _resourceName = resourceName;
            Console.WriteLine($"{_resourceName} - Resource acquired.");
        }

        public void PerformOperation()
        {
            Console.WriteLine($"{_resourceName} - Performing some operation.");
        }

        public void Dispose()
        {
            Console.WriteLine($"{_resourceName} - Resource disposed.");
        }
    }
}
