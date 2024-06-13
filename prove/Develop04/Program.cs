using System;

class Program
{
    static void Main(string[] args)
    {
        bool _running = true;
        string _selection;
        string _rest;
        string _name;
        string _description;
        int _duration = 0;

        while (_running == true)
        {
            Console.WriteLine("Please chose an activity.");
            Console.WriteLine("1) Breathing");
            Console.WriteLine("2) Reflecting");
            Console.WriteLine("3) Listing");
            Console.WriteLine("4) Quit");
            Console.WriteLine();
            _selection = Console.ReadLine();
            Console.WriteLine();

            if(_selection != "4")
            {
                Console.WriteLine("How many seconds would you like to do the selected activity?: ");
                _rest = Console.ReadLine();
                _duration = Convert.ToInt32(_rest);
            }

            Console.Clear();

            if (_selection == "1" || _selection == "Breathing")
            {
                _name = "Breathing";
                _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Breathing newBreathing = new Breathing(_name, _description, _duration);
                newBreathing.BreathInAndOut();
            }
            else if (_selection == "2" || _selection == "Reflecting")
            {
                _name = "Reflecting";
                _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Reflecting newReflecting = new Reflecting(_name, _description, _duration);
                newReflecting.Reflect();
            }
            else if (_selection == "3" || _selection == "Listing")
            {
                _name = "Listing";
                _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                Listing newListing = new Listing(_name, _description, _duration);
                newListing.List();
            }
            else if (_selection == "4" || _selection == "Quit")
            {
                _running = false;
            }
            else
            {
                Console.WriteLine("That is not a valid selection.");
                Console.WriteLine();
            }
        }
    }
}