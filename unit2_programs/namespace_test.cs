using System;
namespace MyNamespace{
    public class SampleClass{
        public static void MyMethod(){
            Console.WriteLine("The sample class method was called!");
        }
    }
}
namespace MyProgram{
    class Program{
        static void Main(){
            MyNamespace.SampleClass.MyMethod();
        }
    }
}