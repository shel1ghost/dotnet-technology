using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        Stack<string> st = new Stack<string>();
        st.Push("astra");
        st.Push("macuser");
        st.Push("shellghost");
        
        //printing elements in stack
        foreach(var elm in st){
            Console.WriteLine(elm);
        }
    }
}