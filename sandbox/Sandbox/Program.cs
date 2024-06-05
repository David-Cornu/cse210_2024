using System;

class Program
{
    static void Main(string[] args)
    {
       while (true)
       {
        Console.Write("|\b");
        Thread.Sleep(1000);
        Console.Write("\\\b");
        Thread.Sleep(1000);
        Console.Write("-\b");
        Thread.Sleep(1000);
        Console.Write("/\b");
        Thread.Sleep(1000);

       }
    }
}