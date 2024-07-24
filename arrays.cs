using System;
class Program{
    static void Main(){
        char[] vowels = new char[5] {'a', 'e', 'i', 'o', 'u'};
        //char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'}; -> valid
        for(int i=0; i < vowels.Length; i++){
            Console.WriteLine(vowels[i]);
        }

        int[] numbers = new int[4];
        Console.WriteLine("Enter 4 numbers: ");
        for(int i=0; i < numbers.Length; i++){
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Your numbers are: ");
        foreach(int num in numbers){
            Console.WriteLine(num);
        }

    }
}