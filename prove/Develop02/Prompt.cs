using System;

public class Prompt
{   
    public void NewPrompt()
    {
        Random randomGenerator = new Random();
        int randomPrompt = randomGenerator.Next(0,6);

        List<string> prompts = new List<string>
        {
            "What is something interesting that happened today?",
            "What merical have you seen today?",
            "What did you do today?",
            "Did anything fun happen today?",
            "Did you enjoy anything about to day?",
            "Did someone do anything special for you?",
        }; 
        
        string prompt = prompts[randomPrompt];

        Console.WriteLine(prompt);
    }
}