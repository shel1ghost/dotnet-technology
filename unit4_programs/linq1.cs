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

        //using linq to find students having age less than 20
        Student[] teens_std = students.Where(s => s.age <= 19 && s.age >= 12).ToArray();

        //printing elements of teens_std
        foreach(var std in teens_std){
            Console.WriteLine("Name: {0}\nAge:{1}", std.name, std.age);
        }

        //using linq to find first student whose name is "Astra"
        Student name1 = students.Where(s => s.name == "Astra").FirstOrDefault();
        Console.WriteLine(name1.name);

        //using linq to find student whose id is 2
        Student name2 = students.Where(s => s.id == 2).FirstOrDefault();
        Console.WriteLine(name2.name);


    }
}