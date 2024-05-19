using System;

public class Prompt
{   
    public void NewPrompt()
    {
        Random randomGenerator = new Random();
        int randomPrompt = randomGenerator.Next(0,6);

        List<string> prompts = new List<string>{
            "What is something interesting that happened today?",
            "what merical have you seen today?",
            "What did you do today?",
            "Did anything fun happen today?",
            "",
            "",
        }; 
        
        string prompt = prompts[randomPrompt];

        Console.WriteLine(prompt);
    }
}