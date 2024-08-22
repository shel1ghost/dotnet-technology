using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        Queue<string> q = new Queue<string>();
        q.Enqueue("ishq wala love");
        q.Enqueue("apna bana le");
        q.Enqueue("nazm nazm");

        //printing all elements
        Console.WriteLine("All elements are:");
        foreach(string elm in q){
            Console.WriteLine(elm);
        }
    }
}