using System;
class Program{
  static void Main(){
    string str1 = "astra";
    Console.WriteLine("The index of s in string {0} is {1}", str1, str1.IndexOf("s"));
    Console.WriteLine("The hash code of string {0} is {1}", str1, str1.GetHashCode());
    
    string str2 = "aStrA";
    Console.WriteLine("The lowercase of string {0} is {1}", str2, str2.ToLower());
    Console.WriteLine("The uppercase of string {0} is {1}", str2, str2.ToUpper());
  }
}
