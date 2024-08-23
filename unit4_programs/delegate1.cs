using System;

public delegate void GreetDelegate(string name);

class Program{
    public void GreetPerson(string n){
        Console.WriteLine("Good Morning {0}", n);
    }

    static void Main(){
        Program p = new Program();
        GreetDelegate gd = new GreetDelegate(p.GreetPerson);
        gd("Astra");
        //OR
        gd.Invoke("Shellghost");
    }
}