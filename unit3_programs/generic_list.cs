using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        List<string> students = new List<string>();
        students.Add("Preeti");
        students.Add("Kriti");
        students.Add("Kartik");
        
        //printing elements
        foreach(string elm in students){
            Console.WriteLine("Best student is: {0}", elm);
        }
    }
}