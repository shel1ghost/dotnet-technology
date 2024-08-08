using System;

class User{
    private string name = "Astra";
    private int age = 21;
    public void GetDetails(){
        Console.WriteLine("Name: {0}\nAge:{1}", name, age);
    }
}

class Program{
    static void Main(){
        User usr = new User();
        usr.GetDetails();
    }
}