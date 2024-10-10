using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        // Using LINQ to filter even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        // Printing the even numbers
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
