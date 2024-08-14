using System;

public class MyClass{
    public void PrintData(int num){
        Console.WriteLine("Integer: {0}", num);
    }

    public void PrintData(float f){
        Console.WriteLine("Float: {0}", f);
    }

    public void PrintData(string s){
        Console.WriteLine("String: {0}", s);
    }
}

public class MainProgram{
    static void Main(){
        MyClass c = new MyClass();
        c.PrintData(10);
        c.PrintData(10.50f);
        c.PrintData("Astra");
    }
}