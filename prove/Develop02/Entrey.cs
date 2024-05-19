using System;
public class Entrey
{
    Prompt newPrompt = new Prompt();
    public string NewEntery()
    {
        string entery;
        newPrompt.NewPrompt();
        entery = Console.ReadLine();

        return entery;
    }
}