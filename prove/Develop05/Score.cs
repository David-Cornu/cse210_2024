public class Score
{
    private int _xp;
    private int _xpToLevelUp;
    private int _level;

    public Score(int score)
    {
        _xp = score;
        _level = 0;
        _xpToLevelUp = 1000;
    }

    public void XPToNextLevel()
    {
        if (_level < 1)
        {
            _xpToLevelUp = 1000;
        }
        else
        {
            _xpToLevelUp = _level * 1000;
        }
    }

    public void UpdateLevel()
    {
        if (_xp >= _xpToLevelUp)
        {
            _level = _level + 1;
            XPToNextLevel();
        }
    }

    public void DisplayScore()
    {
        UpdateLevel();
        
        Console.WriteLine($"Your current xp is {_xp}");
        Console.WriteLine($"Your current level is {_level}");
    }

}