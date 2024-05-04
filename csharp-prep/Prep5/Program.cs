using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        
        string name = GetName();
        int userNumb = GetNumber();
        int squa = Square(userNumb);
        
        DisplayResult(name, squa);
  
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string GetName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            
            return name;
        }

        static int GetNumber()
        {
            Console.Write("What is your favorite number: ");
            int usernumb = int.Parse(Console.ReadLine());

            return usernumb;
        }

        static int Square(int userNumb)
        {
            int squa = userNumb * userNumb;

            return squa;
        }

        static void DisplayResult(string name, int squa)
        {
            Console.WriteLine($"{name} you number squared is {squa}.");
        }
    }
}