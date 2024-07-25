using System;
class Program{
    static void Main(){
        int[,] arr = new int[2,2] {{1,2}, {3,4}};
        for(int i=0; i < arr.GetLength(0); i++){
            for(int j=0; j < arr.GetLength(1); j++){
                Console.WriteLine(arr[i, j]);
            }
        }
    }
}