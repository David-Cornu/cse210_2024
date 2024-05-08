using System.ComponentModel.DataAnnotations;

public class Course
{
    public string _classCode;
    public string _className;
    public int _creadits;
    public string _color;

    public void Display()
    {
        Console.WriteLine($"{_classCode} {_className} {_creadits} {_color}");
    }
}