using System;

public class Writeing : Assignment
{
    string _title;

     public Writeing(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWriteingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}