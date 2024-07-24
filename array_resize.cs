using System;
class Program{
    static void Main(String[] args){
        string[] names = new string[5] {"Astra", "Ashmita", "Urmila", "Erika", "Simran"};
        Array.Resize(ref names, 2);
        foreach(string name in names){
            Console.WriteLine(name);
        }  
    }
}