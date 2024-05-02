using System;

class Program
{
    static void Main(string[] args)
    {
        int gradePercent = 0;
        string userInput = "";

        Console.WriteLine("What is your grade percent?");
        userInput = Console.ReadLine();
        gradePercent = int.Parse(userInput);
        Console.WriteLine();

        if (gradePercent == 90 || gradePercent > 90)
        {
            Console.WriteLine("Your grade is A.");
        } 
        else if (gradePercent == 80 || gradePercent >80)
        {
            Console.WriteLine("Your grade is B.");
        }
        else if (gradePercent == 70 || gradePercent > 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (gradePercent == 60 || gradePercent >60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade id F");
        }
    }
}