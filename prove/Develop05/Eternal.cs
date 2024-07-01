public class Eternal : Goal
{
    public Eternal()
    {
        _score = 50;
        _count = 0;
    }

    public override void CreateGoal()
    {
        string inputName;
        Console.WriteLine("What Goal would you like to set?");
        inputName = Console.ReadLine();
        _name = inputName;
    }

    public void CreateGoalFromSave(string name, int count)
    {
        _name = name;
        _count = count;
    }

    public override Tuple<int, int> RecordEvent()
    {
        _count += 1;
        var returnValue = new Tuple<int, int>(_score, _count);
        return returnValue;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"You have done {_name} {_count} times.");
    }

    public override Tuple<string, int, int, int> SaveGoal()
    {
        var saveTup = new Tuple<string, int, int, int>(_name, _count, 0, 3);
        return saveTup;
    }
}