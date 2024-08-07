using System;

class Auth{
    public void Register(){
        Console.WriteLine("Register User!");
    }
    public void Login(){
        Console.WriteLine("Login User!");
    }
}

interface CRUD{
    void AddData();
    void ListData();
    void UpdateData();
    void DeleteData();
}

class User:Auth, CRUD{
    public void AddData(){
        Console.WriteLine("Add Data!");
    }
    public void ListData(){
        Console.WriteLine("List Data!");
    }
    public void UpdateData(){
        Console.WriteLine("Update Data!");
    }
    public void DeleteData(){
        Console.WriteLine("Delete Data!");
    }
}

class Program{
    static void Main(){
        User usr = new User();
        usr.Register();
        usr.Login();
        usr.AddData();
        usr.ListData();
        usr.UpdateData();
        usr.DeleteData();
    }
}