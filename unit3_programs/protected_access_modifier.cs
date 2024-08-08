using System;

class Person{
    protected string name = "Astra";
    public void PrintDetails(){
        Console.WriteLine("Name: {0}", name);
    }
}

class Student:Person{
    static void Main(){
        Student std = new Student();
        std.name = "Babi";
        std.PrintDetails();
    }
}