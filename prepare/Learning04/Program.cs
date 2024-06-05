using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assign.GetSummery());

        Math mat = new Math("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mat.GetSummery());
        Console.WriteLine(mat.GetHomeworkList());

        Writeing write = new Writeing("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(write.GetSummery());
        Console.WriteLine(write.GetWriteingInformation());
    }
}