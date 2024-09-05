using System.Linq;
using System;

public delegate string SayName(string name);

class Program{
  static void Main(){
    SayName s = delegate(string name){
      return "Hello "+name;
    };

    string greet = s.Invoke("Astra");
    Console.WriteLine(greet);
  }
}
