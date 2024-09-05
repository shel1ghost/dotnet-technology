using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    static void Main(){
        IList<string> names = new List<string>(){ "Babi", "Nuna", "Urmila", "Pradhuna", "Khem", "Sangam"};
        var devotees = names.Select( n => n+" will go to Doleshwar Mahadev");
        foreach(string n in devotees){
            Console.WriteLine(n);
        }
    }
}