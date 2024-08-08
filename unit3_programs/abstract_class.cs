using System;

abstract class Info{
    abstract public void GetDetails(string name, int age);
    public void sayHello(){
        Console.WriteLine("Hello from abstract class!");
    }
}

class User:Info{
    public override void GetDetails(string n, int a){
        Console.WriteLine("Name: {0}\nAge: {1}", n, a);
    }
}

class Program{
    static void Main(String[] args){
        User usr = new User();
        usr.GetDetails("Astra", 21);
        usr.sayHello();
    }
}
