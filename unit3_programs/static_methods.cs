using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public static class Student
    {
        private static int noofStudent;
        public static void AddStudent()
        {
            noofStudent++;
        }
        public static void PrintStudent()
        {
            Console.WriteLine("The number of student is " + noofStudent);
        }
    }

    public class Teacher
    {
        static int countTeacher = 0;
        int countCourse = 0;
        public void AddTeacher()
        {
            countTeacher++;
            countCourse++;
        }
        public static void PrintTeacherDetails()
        {
            Console.WriteLine("The number of teacher "+ countTeacher);
        }
        public void PrintCourseDetails()
        {
            Console.WriteLine("The number of course " + countCourse);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.AddStudent();
            Student.PrintStudent();
            Student.AddStudent();
            Student.AddStudent();
            Student.PrintStudent();

            Teacher t = new Teacher();
            t.AddTeacher();
            t.PrintCourseDetails();
            Teacher.PrintTeacherDetails();

            Teacher t2 = new Teacher();
            t2.AddTeacher();
            t2.AddTeacher();
            Teacher.PrintTeacherDetails();
            t2.PrintCourseDetails();


        }
    }
}
