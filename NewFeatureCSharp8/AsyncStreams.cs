using System.Runtime.CompilerServices;

namespace AsyncStreams
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Fetching data asynchronously...");

            // Using asynchronous stream
            await foreach (var number in GetNumbersAsync())
            {
                Console.WriteLine($"Received number: {number}");
            }

            Console.WriteLine("\nAsync disposal demo:");

            // Using asynchronous disposal
            await using var resource = new AsyncDisposableResource();
            await resource.UseResourceAsync();
        }

        // Asynchronous stream using IAsyncEnumerable<T>
        static async IAsyncEnumerable<int> GetNumbersAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int i = 1; i <= 5; i++)
            {
                await Task.Delay(1000); // Simulate async data fetch
                yield return i; // Return a number to the async stream
            }
        }
    }

    // Demonstrating asynchronous disposal
    public class AsyncDisposableResource : IAsyncDisposable
    {
        public async Task UseResourceAsync()
        {
            Console.WriteLine("Using resource...");
            await Task.Delay(1000); // Simulate some asynchronous work
            Console.WriteLine("Finished using resource.");
        }

        // Asynchronous disposal logic
        public async ValueTask DisposeAsync()
        {
            Console.WriteLine("Disposing resource asynchronously...");
            await Task.Delay(1000); // Simulate asynchronous cleanup
            Console.WriteLine("Resource disposed.");
        }
    }
}
