using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;

public class Activity
{
    protected string _title;
    protected string _desc;
    protected int _duration;

    public Activity(string title, string desc, int dur)
    {
        _title = title;
        _desc = desc;
        _duration = dur;
    }

    public void Animation(int selection)
    {
        int rest = 1000;
        int run = 5;
        int selectedAnimation = selection;
        List<string> animation = new List<string>();

        if(selectedAnimation == 1)
        {
            
            animation.Add("|");
            animation.Add("/");
            animation.Add("-");
            animation.Add("\\");
        }
        else if(selectedAnimation == 2)
        {
            animation.Add("5");
            animation.Add("4");
            animation.Add("3");
            animation.Add("2");
            animation.Add("1");  
        }

         DateTime endTime = DateTime.Now.AddSeconds(run);
        while (DateTime.Now < endTime)
        {
            foreach(string ani in animation)
            {
                Console.Write(ani);
                Thread.Sleep(rest);
                Console.Write("\b \b");
            }
            
        }

    }

    public void Intro()
    {
        Console.WriteLine();
        Console.WriteLine($"The activity you chose is {_title}.");
        Console.WriteLine();
        Console.WriteLine(_desc);
        Console.WriteLine("Get ready.");
        Console.WriteLine();
        Animation(1);
    }

    public void Outro()
    {
        Console.WriteLine($"You have finised {_duration} seconds of the {_title} activity.");
    }
}