using System;
using System.Linq;
using System.Collections.Generic;

class Program{
    static void Main(){
        IList<string> courses = new List<string>(){
            "C# Tutorials",
            "Java",
            "Python Tutorials",
            "Ruby"
        };

        //linq query syntax
        var result = from p in courses where p.Contains("Tutorials") select p;

        foreach(var elm in result){
            Console.WriteLine(elm);
        }

        //linq method syntax
        var result2 = courses.Where(p => p.Contains("Tutorials"));
        foreach(var elm in result2){
            Console.WriteLine(elm);
        }
    }
}