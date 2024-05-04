using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        int userNumb = -1;
        int biggest = -10000000;
        int sum = 0;
        float avg = 0;

        List<int> numb = new List<int>();

        while (userNumb != 0)
        {
            Console.WriteLine("Enter a list number of numbers. Enter 0 when finished");
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            userNumb = int.Parse(userInput);
            if (userNumb != 0)
            {
                numb.Add(userNumb);
            }
        }
        
        foreach (int number in numb)
        {
            sum += number;
        }

        foreach (int number in numb)
        {
            avg = sum/numb.Count;
        }

        foreach (int number in numb)
        {
            if (number > biggest)
            {
                biggest = number;
            }
        }

        Console.WriteLine($"This is the sum of your numbers: {sum}");
        Console.WriteLine($"This is the average of your numbers: {avg}");
        Console.WriteLine($"This is the largest number: {biggest}");
    }
}