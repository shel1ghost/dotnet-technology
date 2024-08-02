using System;

public class Person{
    private int id;
    private string name;
    private string address;
    private long phone;

    // public int Id{
    //     get{ return id; }
    //     set{ id = value; }
    // }
    // public string Name{
    //     get{ return name; }
    //     set{name = value; }
    // }
    // public string Address{
    //     get{ return address; }
    //     set{ address = value; }
    // }
    // public long Phone{
    //     get{ return phone; }
    //     set{ phone = value; }
    // }

    public Person(int id, string name, string address, long phone){
        this.id = id;
        this.name = name;
        this.address = address;
        this.phone = phone;
    }

    public void PersonDetails(){
        Console.WriteLine($"ID: {id}\nName: {name}\nAddress: {address}\nPhone: {phone}");
    }
}

public class Student:Person{
    private int std_class;
    private long fees;
    private float marks;
    private string grade;
    
    public Student(int id, string name, string address, long phone, int std_class, long fees, float marks, string grade):base(id, name, address, phone){
        this.std_class = std_class;
        this.fees = fees;
        this.marks = marks;
        this.grade = grade;
    }
    public void StudentDetails(){
        base.PersonDetails();
        Console.WriteLine($"Class: {std_class}\nFees: {fees}\nMarks: {marks}\nGrade: {grade}\n");
    }
}

public class Staff:Person{
    private string designation;
    private long salary;

    public Staff(int id, string name, string address, long phone, string designation, long salary):base(id, name, address, phone){
        this.designation = designation;
        this.salary = salary;
    }

    public void StaffDetails(){
        base.PersonDetails();
        Console.WriteLine($"Designation: {designation}\nSalary: {salary}");
    }
}

public class TechnicalStaff:Staff{
    private string qualification;
    private string subject;

    public TechnicalStaff(int id, string name, string address, long phone, string designation, long salary, string qualification, string subject):base(id, name, address, phone, designation, salary){
        this.qualification = qualification;
        this.subject = subject;
    }

    public void TechnicalStaffDetails(){
        base.StaffDetails();
        Console.WriteLine($"Qualification: {qualification}\nSubject: {subject}");
    }
}

public class NonTechnicalStaff:Staff{
    private string dname;
    private string superior;
    public NonTechnicalStaff(int id, string name, string address, long phone, string designation, long salary, string dname, string superior):base(id, name, address, phone, designation, salary){
        this.dname = dname;
        this.superior = superior;
    }
    
    public void NonTechnicalStaffDetails(){
        base.StaffDetails();
        Console.WriteLine($"Dname: {dname}\nSuperior: {superior}");
    }
}

class Program{
    public static void Main(String[] args){
        Person p = new Person(101,"Astra", "Lalitpur", 9808012345);
        //p.PersonDetails();
        Student std = new Student(101,"Astra", "Lalitpur", 9808012345, 12, 40000, 82.60f, "A");
        //std.StudentDetails();
        Staff stf = new Staff(101,"Astra", "Lalitpur", 9808012345, "CEO", 120000);
        //stf.StaffDetails();
        TechnicalStaff ts = new TechnicalStaff(101,"Astra", "Lalitpur", 9808012345, "CEO", 120000, "BCA", "Computer Science");
        //ts.TechnicalStaffDetails();
        NonTechnicalStaff nts = new NonTechnicalStaff(101,"Astra", "Lalitpur", 9808012345, "CEO", 120000, "Social", "Senior");
        nts.NonTechnicalStaffDetails();
    }
}