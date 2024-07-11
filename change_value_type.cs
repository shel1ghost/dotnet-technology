using System;
class Program {
    static void ChangeValueType (int x){
        x = 10;
        Console.WriteLine($"The num value during method is {x}");
    }
    static void Main (String[] args){
        int num = 20;
        Console.WriteLine($"The num value before method is {num}");
        ChangeValueType(num);
        Console.WriteLine($"The num value after method is {num}");
    }
}