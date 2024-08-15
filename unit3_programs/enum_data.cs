using System;

class EnumDemo{
    enum WeekDay{
        Monday,
        Tuesday,
        Wednesday = 20,
        Thursday,
        Friday,
        Saturday
    }

    static void Main(){
        Console.WriteLine(WeekDay.Monday);
        Console.WriteLine((int)WeekDay.Friday);
    }
}