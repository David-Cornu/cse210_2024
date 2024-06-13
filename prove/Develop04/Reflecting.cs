using System;

public class Reflecting : Activity
{
     public Reflecting(string name, string desc, int dur):base(name, desc, dur)
    {
      _title = name;
      _desc = desc;
      _duration = dur;
    }

    string[] _prompts = ["Think of a time when you stood up for someone else.",
     "Think of a time when you did something really difficult.",
     "Think of a time when you helped someone in need.", 
     "Think of a time when you did something truly selfless."];

    string[] _questions = ["Why was this experience meaningful to you?",
     "Have you ever done anything like this before?", 
     "How did you get started?", 
     "How did you feel when it was complete?",
     "What made this time different than other times when you were not as successful?",
     "What is your favorite thing about this experience?",
     "What could you learn from this experience that applies to other situations?",
     "What did you learn about yourself through this experience?", 
     "How can you keep this experience in mind in the future?"];

     public void Reflect()
     {
         Random randomGenerator = new Random();
         Random randomGenerator1 = new Random();
         int selectedPropmpt = randomGenerator.Next(0, _prompts.Length);
         int selectedQuestion = randomGenerator1.Next(0, _questions.Length);

         Intro();

         Console.Clear();

         Console.WriteLine();
         Console.WriteLine(_prompts[selectedPropmpt]);
         Console.WriteLine();
         Animation(1);
         Console.WriteLine();
         Console.WriteLine(_questions[selectedQuestion]);
         Console.WriteLine();
         Animation(2);
         
         DateTime endTime = DateTime.Now.AddSeconds(_duration);
         while (DateTime.Now < endTime)
         {
            Animation(1);
         }

         Outro();
         Thread.Sleep(5000);
         Console.Clear();
     }
}