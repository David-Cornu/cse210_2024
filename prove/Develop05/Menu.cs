using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Linq;
public class Menu
{
    private bool _running = true;
    private string _userInput;
    private string _fileName = "save.txt";
    private string _seperator = "*=*";
    private int _runScore;
    public List<Goal> goals = new List<Goal>{};

    public void CreatMenu()
    {
        while (_running == true)
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Create a simple goal");
            Console.WriteLine("2) Create a check list goal");
            Console.WriteLine("3) Create a Eternal goal");
            Console.WriteLine("4) Check xp and level");
            Console.WriteLine("5) Update Goal");
            Console.WriteLine("6) Display Goal");
            Console.WriteLine("7) Load");
            Console.WriteLine("8) Save");
            Console.WriteLine("9) Quit");
            _userInput = Console.ReadLine();

            Console.Clear();

            UseInput(_userInput);
        }
    }

    private void UseInput(string input)
    {
        if (input == "1")
        {
            Simple simple1 = new Simple();
            simple1.CreateGoal();
            goals.Add(simple1);
            
        }
        else if (input == "2")
        {
            CheckList checkList1 = new CheckList();
            checkList1.CreateGoal();
            goals.Add(checkList1);
        }
        else if (input == "3")
        {
            Eternal eternal1 = new Eternal();
            eternal1.CreateGoal();
            goals.Add(eternal1);
        }
        else if (input == "4")
        {
            Score score1 = new Score(_runScore);
            
            score1.DisplayScore();
            
            HoldToRead();
        }
        else if (input == "5")
        {
            int goalNum = 1;
            string inputUpdate;
            int inputNum;
            int updateNum;
            Tuple<int, int> tup;

            foreach(var goal in goals)
            {
                Console.Write($"{goalNum}) ");
                goal.DisplayGoal();
                goalNum += 1;
            }

            Console.WriteLine("What Goal would you like to update?");

            inputUpdate = Console.ReadLine();
            // next 5 lines were gotten from https://codeeasy.io/lesson/input_validation?course=mellanniva
            while(!int.TryParse(inputUpdate, out updateNum))
                {
                    Console.WriteLine("please enter a number within range");
                    inputUpdate = Console.ReadLine();
                }
            inputNum = Convert.ToInt32(inputUpdate);
            if (inputNum > 0 && inputNum < goalNum )
            {
                updateNum = inputNum - 1;
                tup = goals.ElementAt(updateNum).RecordEvent();
                _runScore += tup.Item1;
                if (tup.Item2 == -1)
                {
                    goals.RemoveAt(updateNum);
                }   
            }
            else
            {
                Console.WriteLine("");
            }

        }
        else if (input == "6")
        {
            foreach (var goal in goals)
            {
                goal.DisplayGoal();
            }
            HoldToRead();
        }
        else if (input == "7")
        {
            Load();
        }
        else if (input == "8")
        {
            Save();
        }
        else if (input == "9")
        {
            _running = false;
        }
        else
        {
            Console.WriteLine("Please enter a valid choise.");
        }
    }

    private void HoldToRead()
    {
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine(); 
    }

    private void Save()
    {
        using(StreamWriter writetext = new StreamWriter(_fileName))

        foreach(var goal in goals)
            {
                writetext.Write(goal.SaveGoal() + _seperator);
            }
    }

    private void Load()
    {
        // code partually from https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-8.0
        string line;
        string fixName;
        string type;
        string converter;
        string converter1;
        int checkCount;
        int checkTotalcount;

        StreamReader sr = new StreamReader(_fileName);
         line = sr.ReadLine();
                while (line != null)
                {
                   string[] tups = line.Split(_seperator);
                   tups = tups.Take(tups.Count() - 1).ToArray();
                
                    foreach (var tup in tups)
                    {
                        string[] savetup = tup.Split(",");
                        fixName = Convert.ToString(savetup[0].TrimStart('('));
                        converter1 = Convert.ToString(savetup[1].Trim(' '));                        
                        converter = Convert.ToString(savetup[2].Trim(' '));
                        type = Convert.ToString(savetup[3].TrimEnd(')'));
                        checkCount = Convert.ToInt32(converter1);
                        checkTotalcount = Convert.ToInt32(converter);
                        if (type == " 1")
                        {
                            Simple simpleLoad = new Simple();
                            simpleLoad.CreateGoalFromSave(fixName);
                            goals.Add(simpleLoad);
                        }
                        else if (type == " 2")
                        {
                            CheckList checkListLoad = new CheckList();
                            checkListLoad.CreateGoalFromSave(fixName, checkCount, checkTotalcount);
                            goals.Add(checkListLoad);
                        }
                        else if (type == " 3")
                        {
                            Eternal eternalLoad = new Eternal();
                            eternalLoad.CreateGoalFromSave(fixName, checkCount);
                            goals.Add(eternalLoad);
                        }
                        else
                        {
                            Console.WriteLine("Failed to Load");
                        }            
                    }
                    line = sr.ReadLine();
                    sr.Close();
                }
    }
}