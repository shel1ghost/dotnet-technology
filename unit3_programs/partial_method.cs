using System;

namespace ExampleProgram{

    public partial class BestMovie{
        partial void MovieDetails(string name);
    }

    public partial class BestMovie{
        partial void MovieDetails(string s){
            Console.WriteLine("The best movie is {0}", s);
        }
    }

    public class MainProgram{
        static void Main(){
            BestMovie bm = new BestMovie();
            bm.MovieDetails("Chennai Express"); //inaccessible since partial methods are private
        }
    }
}