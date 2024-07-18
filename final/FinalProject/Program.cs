using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool _running = true;
        string _input;

        while(_running == true)
        {
            Console.Clear();
            Console.WriteLine("Welcome Adventurer");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Play");
            Console.WriteLine("2) Quit");
            Console.WriteLine("");

            _input = Console.ReadLine();

            if (_input == "1")
            {
                Story _story = new Story();
                _story.StoryStart();
                _story.Chapter2();
            }
            else if(_input == "2")
            {
                Console.Clear();
                Console.WriteLine("Thank you for playing.");
                Console.WriteLine("");
                Console.ReadLine();
                _running = false;
            }
            else
            {
                Console.Clear();
            }
        }
    }
}