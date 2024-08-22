using System;
using System.Collections;

class Program{
    static void Main(){
        BitArray ba1 = new BitArray(8);
        BitArray ba2 = new BitArray(8);
        byte[] a = {60};
        byte[] b = {70};

        //storing values 60 and 70 in bitarray
        ba1 = new BitArray(a);
        ba2 = new BitArray(b);

        Console.WriteLine("Element in first bit array ba1: ");
        for(int i=0; i<ba1.Count; i++){
            Console.WriteLine(ba1[i]);
        }

        Console.WriteLine("Element in second bit array ba2: ");
        for(int i=0; i<ba2.Count; i++){
            Console.WriteLine(ba2[i]);
        }

        Console.WriteLine("AND operation between ba1 and ba2");
        BitArray ba3 = new BitArray(8);
        ba3 = ba1.And(ba2);
        for(int i=0; i<ba3.Count; i++){
            Console.WriteLine(ba3[i]);
        }

        Console.WriteLine("XOR operation between ba1 and ba2");
        BitArray ba4 = new BitArray(8);
        ba4 = ba1.Xor(ba2);
        for(int i=0; i<ba4.Count; i++){
            Console.WriteLine(ba4[i]);
        }

        
    }
}