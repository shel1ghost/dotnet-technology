using System;
public class Person{
    private string name;
    public string Name{
        get { return name; }
        set { name = value; }
    }
    public void SayHello(){
        Console.WriteLine("Hello {0}!", name);
    }
}

class Program{
    static void Main(){
        Person p = new Person();
        p.Name = "Astra";
        p.SayHello();
    }
}