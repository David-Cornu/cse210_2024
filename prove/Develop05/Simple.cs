using System.Runtime.CompilerServices;

public class Simple : Goal
{
    public Simple()
    {
        _score = 75;
        _count = -1;
    }

    public override void CreateGoal()
    {
        string inputName;
        Console.WriteLine("What Goal would you like to set?");
        inputName = Console.ReadLine();
        _name = inputName;
    }

    public void CreateGoalFromSave(string name)
    {
        _name = name;
    }

    public override Tuple<int, int> RecordEvent()
    {
        var returnValue = new Tuple<int, int>(_score, _count);
        return returnValue;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"Your goal is to {_name}");
    }

    public override Tuple<string, int, int, int> SaveGoal()
    {
        var saveTup = new Tuple<string, int, int, int>(_name, 0, 0, 1);
        return saveTup;
    }
}