using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _name;
    protected int _score;
    protected int _count;
    

    public Goal()
    {}

    public abstract void CreateGoal();

    public abstract Tuple<int, int> RecordEvent();

    public abstract void DisplayGoal();

    public abstract Tuple<string, int, int, int> SaveGoal();
}