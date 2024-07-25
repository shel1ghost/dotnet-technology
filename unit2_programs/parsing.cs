using System;
class Program {
    static void Main (String[] args){
        int number;
        float height;
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine($"The number is {number}");
        Console.Write("Enter your height: ");
        height = float.Parse(Console.ReadLine());
        Console.WriteLine($"Your height is {height}");
    }
}