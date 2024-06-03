using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture runningScripture = new Scripture();
        bool run = true;
        string input = "";

        while (run == true)
        {
            runningScripture.CreatScripture();
            runningScripture.Display();
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Hide words: ");
            Console.WriteLine("2) Show Words:");
            Console.WriteLine("3) End memorizing:");
            input = Console.ReadLine();
            Console.WriteLine();
            
            if (input == "1")
            {
                runningScripture.Hide();
            }
            else if (input == "2")
            {
                runningScripture.Show();
            }
            else if (input =="3")
            {
                run = false;
            }
        }
    }
}