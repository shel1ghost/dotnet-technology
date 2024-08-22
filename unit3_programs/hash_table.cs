using System;
using System.Collections;

class Program{
    static void Main(){
        Hashtable ht = new Hashtable();
        ht.Add(1, "apna bana le");
        ht.Add(2, "aaj ke baad");
        ht.Add(3, "pehle bhi main");

        ICollection keys = ht.Keys;
        foreach(int k in keys){
            Console.WriteLine(k+": "+ht[k]);
        }

        //removing element
        ht.Remove("pehle bhi main");
        foreach(int k in keys){
            Console.WriteLine(k+": "+ht[k]);
        }

        //updating element
        ht[1] = "malang";
        foreach(int k in keys){
            Console.WriteLine(k+": "+ht[k]);
        }
    }
}