using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("example.txt", "Hello, C# File Handling!");
        Console.WriteLine("File written successfully.");
    }
}
