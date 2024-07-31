using System;
class DeconstructorDemo{
    int id;
    string name;
    public DeconstructorDemo(int id, string name){
        this.id = id;
        this.name = name;
    }
    public void PrintDetails(){
        Console.WriteLine("ID: {0}\nName: {1}", id, name);
    }

    public void Deconstruct(out int user_id, out string username){
        user_id = id;
        username = name;
    }
}

class Program{
    static void Main(){
        DeconstructorDemo demo = new DeconstructorDemo(101, "astra");
        demo.PrintDetails();
        //using deconstructor
        (int uid, string uname) = demo;
        Console.WriteLine("uid: {0}\nuname: {1}", uid, uname);
    }
}