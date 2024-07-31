using System;
class Student{
    int roll;
    string name, email, program, semester, section;
    public Student(int roll, string name, string email, string program, string semester, string section ){
        this.roll = roll;
        this.name = name;
        this.email = email;
        this.program = program;
        this.semester = semester;
        this.section = section;
    }

    public void Deconstruct(out int roll, out string name, out string email, out string program, out string semester, out string section){
        roll = this.roll;
        name = this.name;
        email = this.email;
        program = this.program;
        semester = this.semester;
        section = this.section;
    }
}

class Program{
    static void Main(){
        Student std = new Student(1, "astra", "astra@gmail.com", "BCA", "5th", "None");
        (int roll, string name, string email, string program, string semester, string section) = std;
        Console.WriteLine("Roll: {0}\nName: {1}\nEmail: {2}\nProgram: {3}\nSemester: {4}\nSection: {5}\n", roll, name, email, program, semester, section);
    }
}