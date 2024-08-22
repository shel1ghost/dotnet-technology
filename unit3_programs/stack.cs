using System;
using System.Collections;

class Program{
    static void Main(){
        Stack st = new Stack();
        st.Push(100);
        st.Push(101);
        st.Push(200);
        st.Push(201);

        //printing elements
        Console.WriteLine("All elements:");
        foreach(int elm in st){
            Console.WriteLine(elm);
        }

        //removing elements
        st.Pop();
        Console.WriteLine("After removing a top element:");
        foreach(int elm in st){
            Console.WriteLine(elm);
        }

    }
}