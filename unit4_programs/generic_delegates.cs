using System;

public delegate T Operation<T>(T a, T b);

class Maths{
  public int Add(int a, int b){
    return a+b;
  }
  public int Mul(int a, int b){
    return a*b;
  }
}

class Program{
  static void Main(){
    Maths m = new Maths();

    Operation<int> op = new Operation<int>(m.Add);
    int result = op.Invoke(10, 20);
    Console.WriteLine("Sum is {0}", result);

    Operation<int> op2 = new Operation<int>(m.Mul);
    int result2 = op2.Invoke(10, 20);
    Console.WriteLine("Multiplication is {0}", result2);

  }
}

