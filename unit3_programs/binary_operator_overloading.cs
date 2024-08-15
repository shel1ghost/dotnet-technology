using System;

class Example{
    public int num;
    public Example(int num){
        this.num = num;
    }
    public Example(){}
    public static Example operator +(Example ex1, Example ex2){
        Example ex3 = new Example();
        ex3.num = ex1.num + ex2.num;
        return ex3;
    }
    public void PrintNum(){
        Console.WriteLine(num);
    }
}

class Program{
    static void Main(){
        Example ex1 = new Example(100);
        Example ex2 = new Example(200);
        Example ex3 = new Example();
        ex3 = ex1 + ex2;
        ex3.PrintNum();
    }
}