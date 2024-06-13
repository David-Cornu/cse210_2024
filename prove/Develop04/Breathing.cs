using System;

public class Breathing: Activity
{
    private int _breathRate = 5000;

    
    public Breathing(string name, string desc, int dur):base(name, desc, dur)
    {
        _title = name;
        _desc = desc;
        _duration = dur;
    }
    


    public void BreathInAndOut()
    { 
        Intro();

        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in...");
            Thread.Sleep(_breathRate);
            Console.WriteLine("Breath out...");
            Thread.Sleep(_breathRate);
        }

        Console.WriteLine();
        Outro();
        Thread.Sleep(5000);
        Console.Clear();
    }
}