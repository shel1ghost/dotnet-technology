using System;
public class Person{
    public string name;
    public Person(string pname){
        name = pname;
    }
    public void SayHello(){
        Console.WriteLine("Hello {0}!", name);
    }
}

class Program{
    static void Main(){
        Person p = new Person("Astra");
        p.SayHello();
    }
}