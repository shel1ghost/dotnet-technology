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
            new Student(){id=3, name="missprogrammer", age=18}
        };

        //using linq query to find teen students
        var teens = from s in students where s.age > 12 && s.age <= 19 select s;
        foreach(var std in teens){
            Console.WriteLine(std.name);
        }
    }
}