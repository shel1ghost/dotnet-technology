using System;

class Program{
  static void Main(){
    //expression lambda
    Func<int, int, int> sum = (a, b) => a+b;
    int result1 = sum(10, 20);
    Console.WriteLine("Sum is {0}", result1);

    //statement lambda
    Action<string> print_msg = name => {
      Console.WriteLine("Hello "+name);
      Console.WriteLine("We are learning statement lambda");
    };

    print_msg("Babi");
  }
}
