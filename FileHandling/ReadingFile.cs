using System;
using System.IO;

class Program
{
    static void Main()
    {
        string content = File.ReadAllText("example.txt");
        Console.WriteLine($"File Content: {content}");
    }
}
