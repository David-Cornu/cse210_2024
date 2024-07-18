using System;

public class Armor
{
    // All armor tuples are set up as follows
//(weapon name, armor class, straight needed, index)
   (string, int, int, int)[] _armors =
   {
    ("Plate", 20, 12, 0), ("Brigandine", 15, 10, 1),
    ("Chainmail", 10, 10, 2), ("Gambeson", 8, 0, 3), 
    ("Clothes", 0, 0, 4)
   };

   public int GetArmorSet(int ind)
   {
    var armor = _armors[ind];
    return armor.Item2;
   }

   public int SetArmor()
   {
    int count = 1;
    int userInput;

    foreach (var armor in _armors)
    {
        Console.Write($"{count})");
        Console.WriteLine(armor.Item1);
        count += 1;
    }
    Console.WriteLine("");
    userInput = Convert.ToInt32(Console.ReadLine()) - 1;

    return _armors[userInput].Item2;
   }

   public void ShowArmor(int ind)
   {
    Console.WriteLine(_armors[ind]);
   }
}