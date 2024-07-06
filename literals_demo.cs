using System;
class Program{
  static void Main(String[] args){
    int a = 12;
    int binary = 0b1011101;
    int hex = 0x12efc;
    
    double e = 12.50;
    char ch = '\u0061';

    string name = @"astra";
    bool is_talent = false;
    string null_string = null;

    Console.WriteLine("Integer: "+a);
    Console.WriteLine("Binary: "+binary);
    Console.WriteLine("Hexadecimal: "+hex);
    Console.WriteLine("Double: "+e);
    Console.WriteLine("Character: "+ch);
    Console.WriteLine("String: "+name);
    Console.WriteLine("Boolean: "+is_talent);
    Console.WriteLine("Null: "+null_string);
  }
}
