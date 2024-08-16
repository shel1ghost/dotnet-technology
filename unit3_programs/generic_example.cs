using System;

class GenericExample{
    public static bool AreEqual<T>(T a, T b){
        return a.Equals(b);
    }
}

class MainProgram{
    static void Main(){
        bool equal = GenericExample.AreEqual<int>(25,25);
        if(equal){
            Console.WriteLine("Both are equal");
        }
    }
}