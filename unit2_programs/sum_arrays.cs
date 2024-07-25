using System;
class Program{
    static void Main(String[] args){
        int[,] arr1 = new int[2, 2];
        int[,] arr2 = new int[2, 2];
        int[,] sum = new int[2,2];
        int i, j;
        Console.WriteLine("Enter the elements of first matrix (2x2):");
        for(i=0; i < arr1.GetLength(0); i++){
            for(j=0; j < arr1.GetLength(1); j++){
                arr1[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter the elements of second matrix (2x2):");
        for(i=0; i < arr2.GetLength(0); i++){
            for(j=0; j < arr2.GetLength(1); j++){
                arr2[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        for(i=0; i < sum.GetLength(0); i++){
            for(j=0; j < sum.GetLength(1); j++){
                sum[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        Console.WriteLine("The sum is:");
        for(i=0; i < sum.GetLength(0); i++){
            for(j=0; j < sum.GetLength(1); j++){
                Console.WriteLine(sum[i, j]);
            }
        }
    }
}