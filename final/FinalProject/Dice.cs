using System;

public class Dice
{
    private int _d20;
    private int _d12;
    private int _d10;
    private int _d8;
    private int _d6;
    private int _d4;
    private int _d2;
    
    public int RollD20()
    {
        Random d20rand = new Random();

        _d20 = d20rand.Next(1, 21);

        return _d20;
    }

    public int RollD12()
    {
        Random d12rand = new Random();

        _d12 = d12rand.Next(1, 13);

        return _d12;
    }

    public int RollD10()
    {
        Random d10rand = new Random();

        _d10 = d10rand.Next(1, 11);

        return _d10;
    }

    public int RollD8()
    {
        Random d8rand = new Random();

        _d8 = d8rand.Next(1, 9);

        return _d8;
    }

    public int RollD6()
    {
        Random d6rand = new Random();

        _d6 = d6rand.Next(1, 7);

        return _d6;
    }

    public int RollD4()
    {
        Random d4rand = new Random();

        _d4 = d4rand.Next(1, 5);

        return _d4;
    }

    public int RollD2()
    {
        Random d2rand = new Random();

        _d2 = d2rand.Next(1, 3);

        return _d2;
    }
}