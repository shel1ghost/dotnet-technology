using System;

public delegate void GetFruit(out string fruit);

class Fruit{
    public void GetMango(out string f){
        f = "Mango";
    }
    public void GetOrange(out string f){
        f = "Orange";
    }
    public void GetApple(out string f){
        f = "Apple";
    }
}

class Program{
    static void Main(){
        Fruit f = new Fruit();
        GetFruit gf = new GetFruit(f.GetMango);
        gf += f.GetOrange;
        gf += f.GetApple;

        string fruit;
        gf(out fruit);
        Console.WriteLine(fruit);
    }
}