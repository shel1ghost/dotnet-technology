using System;
class Person{
    public static void AddNumbers(int x, int y = 10){
        Console.WriteLine("The sum of {0} and {1} is {2}", x, y, x+y);
    }
}
class Program{
    static void Main(){
        Person.AddNumbers(10, 10);
        Person.AddNumbers(20);
    }
}