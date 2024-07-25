using System;
class Program{
    static void Main (String[] args){
        string num = "20";
        int number = Convert.ToInt32(num);
        int age = 21;
        string vote = Convert.ToString(age);
        Console.WriteLine($"Your number is {number}\nYour voting age is {vote}");
    }
}