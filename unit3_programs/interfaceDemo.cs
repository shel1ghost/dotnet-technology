using System;

interface IArea{
    void CalculateArea(double a, double b = 0);
}

class Rectangle:IArea{
    public void CalculateArea(double a, double b = 0){
        double area = a*b;
        Console.WriteLine("The area of rectangle is {0}", area);
    }
}

class Circle:IArea{
    public void CalculateArea(double a, double b = 0){
        double area = a*a;
        Console.WriteLine("The area of circle is {0}", area);
    }
}

class Program{
    static void Main(){
        Rectangle r = new Rectangle();
        r.CalculateArea(10, 20);
        Circle c = new Circle();
        c.CalculateArea(10);
    }
}