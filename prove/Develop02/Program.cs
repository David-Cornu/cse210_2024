using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        Journal workingJournal = new Journal();
        bool running = true;
        bool unsavedEntry = false;
        string entry = "";
        
        while (running == true)
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Write new entery:");
            Console.WriteLine("2) Display entery:");
            Console.WriteLine("3) Save to file:");
            Console.WriteLine("4) Load from file:");
            Console.WriteLine("5) Quit:");
            Console.WriteLine();
            string input = Console.ReadLine();

            if (input == "1" | input == "write new entery")
            {
                if (unsavedEntry == false)
                {
                    entry = workingJournal.EnteryWrite();
                    unsavedEntry = true;
                }
                else if (unsavedEntry == true)
                {
                    Console.WriteLine("If you proceed what you have written will be lost.");
                    Console.WriteLine("If you would like to overwrite your curent entry press1");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        entry = workingJournal.EnteryWrite();
                        unsavedEntry = true;
                    }
                }
            }
            else if (input == "2" | input == "display entery")
            {
                workingJournal.EnteryRead();
            }
            else if (input == "3" | input == "save to file")
            {
                unsavedEntry = false;
                workingJournal.Save();
                
            }
            else if (input == "4" | input == "load from file")
            {
                workingJournal.Load();
            }
            else if (input == "5" | input == "quit")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Please enter a appropreate responce");
            }
        }
    }
}