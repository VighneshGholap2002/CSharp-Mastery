using System;

public delegate void SingleDelegate(string message);

class Program
{
    static void PrintMessage(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    static void Main()
    {
        // Creating an instance of the delegate
        SingleDelegate del = new SingleDelegate(PrintMessage);
        
        // Invoking the delegate
        del("Hello from Single Delegate!");
    }
}
