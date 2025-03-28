using System.IO;

class Program
{
    static void Main()
    {
        File.AppendAllText("example.txt", "\nAppended text!");
        Console.WriteLine("Text appended successfully.");
    }
}
