using System;
using System.Collections;

class Program{
    static void Main(){
        ArrayList al = new ArrayList();
        al.Add("astra");
        al.Add("macuser");
        al.Add("missprogrammer");

        //printing elements
        foreach(string elm in al){
            Console.WriteLine(elm);
        }

        Console.WriteLine("Capacity: "+al.Capacity);
        Console.WriteLine("Count: "+al.Count);

        //remove a element
        al.Remove("missprogrammer");
        //sorting elements
        al.Sort();
        foreach(string elm in al){
            Console.WriteLine(elm);
        }

    }
}