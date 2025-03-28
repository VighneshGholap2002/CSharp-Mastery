using System;

class Program
{
    static void PrintMessage(string message) => Console.WriteLine("Message: " + message);

    static void Main()
    {
        // Using Action delegate with one string parameter
        Action<string> action = PrintMessage;
        action("Hello from Action!"); // Output: Message: Hello from Action!

        // Using Action with lambda expression
        Action<int, int> multiplyAction = (a, b) => Console.WriteLine("Product: " + (a * b));
        multiplyAction(4, 5); // Output: Product: 20
    }
}
