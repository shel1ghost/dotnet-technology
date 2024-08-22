using System;
using System.Collections;

class Program{
    static void Main(){
        //sorts according to keys of the elements
        SortedList sl = new SortedList();
        sl.Add(103, "Computer Science");
        sl.Add(101, "Physics");
        sl.Add(102, "Maths");
        ICollection keys = sl.Keys;
        foreach(int k in keys){
            Console.WriteLine(k+": "+sl[k]);
        }
    }
}