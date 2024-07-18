using System;
public class Items
{
    // Items are set up as follows
    // (name, modifire type, modifire, type, index)
    
    (string, string, int, int, int)[] _potions = 
    {
        ("Healing", "Health", 30, 1, 0), ("Poison", "Health", -30, 1, 1)
    };

    (string, string, int, int, int)[] _light = 
    {
        ("Torch", "Light", 1, 2, 0)
    };

    public void ShowItems(Tuple<int, int> item)
    {
        if (item.Item1 == 1)
        {
            Console.WriteLine(_potions[item.Item2].Item1);
        }
        else if (item.Item1 == 2)
        {
            Console.WriteLine(_light[item.Item2].Item1);
        }
    }

    public int UseIteam(Tuple<int, int> item)
    {
        if (item.Item1 == 1)
        {
            var itemToUse = _potions[item.Item2];
            return itemToUse.Item3;
        }
        else if (item.Item1 == 2)
        {
            var itemToUse = _light[item.Item2];
            return itemToUse.Item3;
        }
        else
        {
            return 0;
        }
    }
}