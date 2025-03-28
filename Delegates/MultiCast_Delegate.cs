using System;

public delegate void MultiDelegate(string message);

class Program
{
    static void PrintMessage(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    static void PrintUppercase(string message)
    {
        Console.WriteLine("Uppercase: " + message.ToUpper());
    }

    static void Main()
    {
        MultiDelegate del;

        // Adding multiple methods to the delegate
        del = PrintMessage;
        del += PrintUppercase; // Adding another method

        // Invoking the delegate (calls both methods)
        del("Hello from Multicast Delegate!");
    }
}
