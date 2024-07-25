using System;
class Student{
    public string std_name;
}
class Program {
    static void ChangeReferenceType (Student std2){
        std2.std_name = "Astra";
    }
    static void Main (String[] args){
        Student std1 = new Student();
        std1.std_name = "Babi";
        Console.WriteLine($"Before referencing the method, name is {std1.std_name}");
        ChangeReferenceType(std1);
        Console.WriteLine($"After referencing the method, name is {std1.std_name}");
    }
}