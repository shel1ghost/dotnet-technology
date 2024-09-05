using System;
using System.Linq;

class Student{
    public int id {get; set;}
    public string name {get; set;}
    public int age{get; set;}
}

class Program{
    static void Main(){
        Student[] students = {
            new Student(){id=1, name="Astra", age=20},
            new Student(){id=2, name="Shellghost", age=21},
            new Student(){id=3, name="Missprogrammer", age=18}
        };

        var sorted_std = students.OrderBy(s => s.name);
        foreach(var std in sorted_std){
            Console.WriteLine(std.name);
        }
    }
}