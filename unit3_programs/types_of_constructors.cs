using System;
class ConstructorDemo{
    int a, b;
    //default constructor
    public ConstructorDemo(){
        a = 10;
        b = 20;
    }

    public void PrintAB(){
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }

    //static constructor
    static ConstructorDemo(){
        Console.WriteLine("Static constructor was invoked!");
    }

    //parameterized constructor
    public ConstructorDemo(int a, int b){
        this.a = a;
        this.b = b;
    }

    //copy constructor 
    public ConstructorDemo(ConstructorDemo demo){
        a = demo.a;
        b = demo.b;
    }

}
class Program{
    static void Main(String[] args){
        ConstructorDemo demo = new ConstructorDemo();
        demo.PrintAB();
        ConstructorDemo demo2 = new ConstructorDemo(100, 200);
        demo2.PrintAB();
        ConstructorDemo demo3 = new ConstructorDemo(demo2);
        demo3.PrintAB();
    }
}