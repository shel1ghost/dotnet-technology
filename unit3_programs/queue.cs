using System;
using System.Collections;

class Program{
    static void Main(){
        Queue q = new Queue();
        q.Enqueue("ishq wala love");
        q.Enqueue("apna bana le");
        q.Enqueue("nazm nazm");

        //printing all elements
        Console.WriteLine("All elements are:");
        foreach(string elm in q){
            Console.WriteLine(elm);
        }

        //removing element
        Console.WriteLine("After removing a element:");
        q.Dequeue();
        foreach(string elm in q){
            Console.WriteLine(elm);
        }
    }
}