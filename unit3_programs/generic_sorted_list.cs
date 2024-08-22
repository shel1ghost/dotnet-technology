using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        SortedList<int, string> std = new SortedList<int, string>();
        std.Add(3, "Preeti");
        std.Add(1, "Kriti");
        std.Add(2, "Kartik");

        IList<int> keys = std.Keys;
        foreach(int k in keys){
            Console.WriteLine("{0}: {1}", k, std[k]);
        }
    }
}