using System;
class DestructorDemo{
    string name = "astra";
    public void PrintSomething(){
        Console.WriteLine("Hello from {0}", name);
    }
    ~DestructorDemo (){
        Console.WriteLine("Destructor was invoked!");
    }
}
class Program{
    public static void Main(String[] args){
        DestructorDemo d = new DestructorDemo();
        d.PrintSomething();
    }
}