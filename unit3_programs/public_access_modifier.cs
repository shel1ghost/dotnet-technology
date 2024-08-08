using System;

class User{
    public string name;
    public int age;
    public void GetDetails(){
        Console.WriteLine("Name: {0}\nAge:{1}", name, age);
    }
}

class Program{
    static void Main(){
        User usr = new User();
        usr.name = "Babi";
        usr.age = 21;
        usr.GetDetails();
    }
}