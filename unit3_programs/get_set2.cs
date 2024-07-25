using System;
public class Person{
    private string name;
    public string Name{
        get { return name.ToUpper(); }
        set { name = value.ToLower(); }
    }
    public void SayHello(){
        Console.WriteLine("Hello {0}!", name);
    }
}

class Program{
    static void Main(){
        Person p = new Person();
        p.Name = "Astra";
        Console.WriteLine(p.Name);
        p.SayHello();
    }
}