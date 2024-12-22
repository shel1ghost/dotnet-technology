using System;
using System.Linq;
using System.Collections.Generic;

class Program{
  static void Main(){
    List<int> marks = new List<int>(){10, 20, 45, 68, 50};
    int max = marks.Max();
    int min = marks.Min();
    int sum = marks.Sum();
    int total = marks.Count();
    Console.WriteLine("Max: "+max);
    Console.WriteLine("Min: "+min);
    Console.WriteLine("Sum: "+sum);
    Console.WriteLine("Total: "+total);
  }
}
