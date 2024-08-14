using System;

public class BestMovie{
    public virtual void MovieName(){
        Console.WriteLine("Satyaprem Ki Katha");
    }
}

public class Cinema:BestMovie{
    public override void MovieName(){
        Console.WriteLine("Chenna Express");
    }
}

public class MainProgram{
    static void Main(){
        Cinema c = new Cinema();
        c.MovieName();
    }
}