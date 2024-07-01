public class CheckList : Goal
{

    int _totleCount;

    public CheckList()
    {
        _score = 100;
        _count = 0;
    }

    public override void CreateGoal()
    {
        string inputName;
        string inputCount;
        Console.WriteLine("What Goal would you like to set?");
        inputName = Console.ReadLine();
        Console.WriteLine("Please enter a number in numerical form not written out.");
        Console.WriteLine("How many times do you want to do this goal?");
        inputCount = Console.ReadLine();

        _name = inputName;
        _totleCount = Convert.ToInt32(inputCount);

    }

    public void CreateGoalFromSave(string name, int count, int totalCount)
    {
        _name = name;
        _count = count;
        _totleCount = totalCount;
    }

    public override Tuple<int, int> RecordEvent()
    {
        if (_count < _totleCount)
        {
            _count += 1;
            if (_count >= _totleCount)
            {
                var returnValue = new Tuple<int, int>(_score, -1);
                return returnValue;
            }
            else
            {
                var returnValue = new Tuple<int, int>(_score, _count);
                return returnValue;
            }
        }
        else
        {
            var returnValue = new Tuple<int, int>(_score, -1);
            return returnValue;
        }

        
        
        
    }

    public override void DisplayGoal()
    {

        Console.WriteLine($"You have done {_name} for {_count} out of {_totleCount} times.");
    }

    public override Tuple<string, int, int, int> SaveGoal()
    {
        var saveTup = new Tuple<string, int, int, int>(_name, _count, _totleCount, 2);
        return saveTup;
    }
}