using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        IDictionary<int, string> names = new Dictionary<int, string>();

        names.Add(3, "Preeti");
        names.Add(1, "Kriti");
        names.Add(2, "Kartik");


        ICollection<int> keys = names.Keys;
        foreach(int k in keys){
            Console.WriteLine("{0}: {1}", k, names[k]);
        }
    }
}