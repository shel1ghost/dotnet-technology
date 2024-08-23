using System;

public delegate string GetFruit();

class Fruit{
    public string GetMango(){
        return "Mango";
    }
    public string GetOrange(){
        return "Orange";
    }
    public string GetApple(){
        return "Apple";
    }
}

class Program{
    static void Main(){
        Fruit f = new Fruit();
        GetFruit gf = new GetFruit(f.GetMango);
        gf += f.GetOrange;
        gf += f.GetApple;
        
        string fruit = gf();

        Console.WriteLine(fruit);
    }
}