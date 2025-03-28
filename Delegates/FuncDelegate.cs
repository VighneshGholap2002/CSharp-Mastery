using System;

class Program
{
    static int Square(int num) => num * num;

    static void Main()
    {
        // Using Func with one input (int) and one output (int)
        Func<int, int> squareFunc = Square;
        Console.WriteLine("Square of 5: " + squareFunc(5)); // Output: 25

        // Using Func with lambda expression
        Func<int, int, int> addFunc = (a, b) => a + b;
        Console.WriteLine("Sum of 3 and 7: " + addFunc(3, 7)); // Output: 10
    }
}
