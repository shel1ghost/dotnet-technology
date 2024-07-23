using System;
class Program{
  static void Main(String[] args){
    int i = 10; 
    object obj = i; //boxing
    int j = (int)obj; //unboxing
    Console.WriteLine($"Value of obj object: {obj}");
    Console.WriteLine($"Value of j: {j}");
  }
}
