using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Random randomGenerator = new Random();
        //int randNum = randomGenerator.Next(1,11);
        int randNum = 0;
        int guess = 0;
        string userInput = "";

        Console.WriteLine("What is the magic number?");
        string userNum = Console.ReadLine();
        randNum = int.Parse(userNum);

        while (guess != randNum)
        {
            Console.WriteLine("What is your guess?");
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess == randNum)
            {
                Console.WriteLine("You guessed it!");
            }
            else if(guess < randNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
    }
}