using System;
class Program{
    static void Main(String[] args){
        string[] names = new string[5] {"Astra", "Ashmita", "Urmila", "Erika", "Simran"};
        foreach(string name in names){
            Console.WriteLine(name);
        }
        string[] names2 = new string[5];
        Console.WriteLine("Enter 5 names: ");
        for(int i=0; i < names2.Length; i++){
            names2[i] = Console.ReadLine();
        }
        Console.WriteLine("The names are:" );
        for(int i=0; i < names2.Length; i++){
            Console.WriteLine(names2[i]);
        }
    }
}