using System;

class Program
{
    static void Main(string[] args)
    {
        Course course1 = new();
        course1._classCode = "CSE 210";
        course1._className = "Programing with Classes";
        course1._creadits = 2;
        course1._color = "Green";

        course1.Display();
    }
}