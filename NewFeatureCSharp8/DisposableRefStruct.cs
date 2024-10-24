using System;

namespace DisposableRefStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Disposable ref structs in C# 8:");

            // Use a disposable ref struct in a using statement
            using (var buffer = new DisposableBuffer(10))
            {
                buffer.Fill(42); // Fill the buffer with a value
                buffer.DisplayBuffer(); // Display the buffer's content
            } // Buffer is automatically disposed of at the end of the using block

            Console.WriteLine("Buffer disposed.");
        }
    }

    // Define a ref struct that simulates IDisposable behavior
    ref struct DisposableBuffer
    {
        private int _size;

        // Constructor that initializes the buffer size
        public DisposableBuffer(int size)
        {
            _size = size; // Store the size of the buffer
            Console.WriteLine($"Initialized buffer of size {size} on the stack.");
        }

        // Method to fill the buffer with a specific value
        public void Fill(int value)
        {
            Span<int> buffer = stackalloc int[_size]; // Use stackalloc directly in the method
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = value; // Fill the stack-allocated buffer
            }
        }

        // Method to display the buffer's contents
        public void DisplayBuffer()
        {
            Span<int> buffer = stackalloc int[_size]; // Use stackalloc to create a new buffer
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = i + 1; // Example: Fill with values 1, 2, ..., _size
            }

            Console.WriteLine("Buffer contents:");
            foreach (var item in buffer)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Method to simulate disposing resources (logging)
        public void Dispose()
        {
            // Since this is a ref struct, the buffer is already on the stack,
            // no explicit cleanup is needed, but we can still log if necessary.
            Console.WriteLine("Releasing buffer resources (if any).");
        }
    }
}
