using System;
class Program{
    static void Main (String[] args){
        //implicit typecasting
        int a = 20, b= 10;
        long c = a+b;
        Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);

        //explicit typecasting
        float x = 61.5f;
        int y = (int)x;
        Console.WriteLine("The value of y is {0}", y);
    }
}