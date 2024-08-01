using System;

struct Books{
    private string title;
    private string author;
    private int id;

    public void AssginValue(string title, string author, int id){
        this.title = title;
        this.author = author;
        this.id = id;
    }

    public void DisplayBook(){
        Console.WriteLine("The title is {0}", title);
        Console.WriteLine("The author is {0}", author);
        Console.WriteLine("The id is {0}", id);
    }
}

class Program{
    static void Main(){
        Books bk = new Books();
        bk.AssginValue("Computer Science", "Astra", 101);
        bk.DisplayBook();
    }
}