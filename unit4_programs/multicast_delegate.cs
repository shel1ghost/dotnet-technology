using System;

public delegate void MathDelegate(int x, int y);

class Maths{
    public void Add(int a, int b){
        Console.WriteLine("Sum is {0}", a+b);
    }
    public void Sub(int a, int b){
        Console.WriteLine("Sub is {0}", a-b);
    }
    public void Mul(int a, int b){
        Console.WriteLine("Mul is {0}", a*b);
    }
}

class Program{
    static void Main(){
        Maths m = new Maths();
        MathDelegate md = new MathDelegate(m.Add);
        md += m.Sub;
        md += m.Mul;
        md(20, 10);
    }
}