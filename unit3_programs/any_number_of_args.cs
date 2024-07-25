using System;
class Students{
    public static void PrintStudents(params string[] names){
        foreach(var std in names){
            Console.WriteLine("{0} is best student!", std);
        }
    }
    public static void AnyTypeArgs(params object[] data){
        foreach(var elm in data){
            Console.WriteLine(elm);
        }
    }
}

class Program{
    static void Main(){
        Students.PrintStudents("Astra");
        Students.PrintStudents("Ashmita", "Urmila", "Rohini");
        Students.AnyTypeArgs(10, false, "Advait");
    }
}