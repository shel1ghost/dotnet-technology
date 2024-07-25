using System;
class Program{
  static void Main(){
    char ch = 'A';
    char ch2 = 'b';
    Console.WriteLine(ch.Equals('c'));
    Console.WriteLine(Char.IsLetter(ch));
    Console.WriteLine(Char.IsNumber(ch));
    Console.WriteLine(Char.ToUpper(ch2));
    Console.WriteLine(Char.ToLower(ch));
  }
}
