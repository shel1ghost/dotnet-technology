using System;
namespace MyNamespace{
    namespace NestedNamespace{
        public class SampleClass{
            public static void MyMethod(){
                Console.WriteLine("The sample class method was called!");
            }
        }
    }
}
namespace MyProgram{
    class Program{
        static void Main(){
            MyNamespace.NestedNamespace.SampleClass.MyMethod();
        }
    }
}