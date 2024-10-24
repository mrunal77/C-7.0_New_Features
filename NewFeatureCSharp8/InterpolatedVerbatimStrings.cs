using System;

namespace InterpolatedVerbatimStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables for interpolation
            string folder = "Documents";
            string file = "Report.txt";

            // Before C# 8: Using the older @$ syntax
            string oldSyntax = @$"C:\Users\John\{folder}\{file}";
            Console.WriteLine("Old syntax (C# 7.3 or earlier):");
            Console.WriteLine(oldSyntax);

            // C# 8: Using the new $@ syntax
            string newSyntax = $@"C:\Users\John\{folder}\{file}";
            Console.WriteLine("\nNew syntax (C# 8):");
            Console.WriteLine(newSyntax);

            // Example with multi-line interpolated verbatim string
            string multiLine = $@"
Hello, {Environment.UserName}!

Your file is located at:
C:\Users\John\{folder}\{file}
";
            Console.WriteLine("\nMulti-line interpolated verbatim string:");
            Console.WriteLine(multiLine);
        }
    }
}
