using System;

namespace ExampleProgram{

    public partial class MyClass{
        private string movie;
        private string director;
        public MyClass(string movie, string director){
            this.movie = movie;
            this.director = director;
        }
    }

    public partial class MyClass{
        public void MovieDetails(){
            Console.WriteLine("Movie Name: {0}\nDirector: {1}", movie, director);
        }
    }

    public class MainProgram{
        static void Main(){
            MyClass c = new MyClass("Satyaprem Ki Katha", "Sameer Vidwans");
            c.MovieDetails();
        }
    }
}

