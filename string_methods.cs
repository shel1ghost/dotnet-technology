using System;
class Program{
    static void Main(String[] args){
        //Contains(char)
        string str1 = "astra";
        char ch = 's';
        if(str1.Contains(ch)){
            Console.WriteLine($"String {str1} contains character {ch}");
        }
        //Contains(string)
        string str2 = "astra is my hacker alias";
        string str3 = "hacker";
        if(str2.Contains(str3)){
            Console.WriteLine($"String \"{str2}\" contains the string \"{str3}\"");
        }
        //Remove(Int32)
        string str4 = "Hello this is astra!";
        string str5 = str4.Remove(5);
        Console.WriteLine(str5); //Hello
        //Remove(Int32, Int32)
        string str6 = str4.Remove(5, 9);
        Console.WriteLine(str6); //Helloastra!

    }
}