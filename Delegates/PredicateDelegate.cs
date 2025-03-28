using System;
using System.Collections.Generic;

class Program
{
    static bool IsEven(int number) => number % 2 == 0;

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        // Using Predicate delegate
        Predicate<int> evenPredicate = IsEven;

        // Finding first even number
        int evenNumber = numbers.Find(evenPredicate);
        Console.WriteLine("First even number: " + evenNumber); // Output: 2
    }
}
