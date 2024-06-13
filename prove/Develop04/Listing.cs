using System;
using System.Runtime.CompilerServices;

public class Listing : Activity
{
    int _listLeingth;
    string _userInput;
    string[] prompts = ["Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"];
    public List<string> items = new List<string>();

     public Listing(string name, string desc, int dur):base(name, desc, dur)
    {
        _title = name;
        _desc = desc;
        _duration = dur;
    }

    public void AddToList()
    {
        string input = Console.ReadLine();
        items.Add(input);
    }

    public void List()
    {
        Intro();

        Console.Clear();

        Random randomGenerator = new Random();
        int selectedPropmpt = randomGenerator.Next(0, prompts.Length);

        Console.WriteLine(prompts[selectedPropmpt]);
        Animation(2);
        Console.WriteLine("Start listing:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            _userInput = Console.ReadLine();
            items.Add(_userInput);
        }
        
        _listLeingth = items.Count();

        Console.WriteLine($"You worte {_listLeingth} things.");

        Console.WriteLine();
        Outro();
        Thread.Sleep(5000);
        Console.Clear();
    }
}