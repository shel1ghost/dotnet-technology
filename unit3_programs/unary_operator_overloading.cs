using System;

class Example{
    public int num1, num2;
    public Example(int num1, int num2){
        this.num1 = num1;
        this.num2 = num2;
    }
    public Example(){}
    public static Example operator -(Example ex){
        ex.num1 = -ex.num1;
        ex.num2 = -ex.num2;
        return ex;
    }
    public void PrintNum(){
        Console.WriteLine("Num1: {0}\nNum2: {1}", num1, num2);
    }
}

class Program{
    static void Main(){
        Example ex1 = new Example(100, 200);
        ex1.PrintNum();
        Example ex2 = new Example();
        ex2 = -ex1;;
        ex2.PrintNum();
    }
}