using System;
using System.Formats.Asn1;

public class Weapon
{
// All weapon tuples are set up as follows
//(weapon name, dice used, number of hands needed, index)
   (string, string, int, int)[] _weapons =
   {
    ("Arming Sword", "10", 1, 0), ("Longsword", "10", 2, 1),
    ("Dagger", "4", 1, 2), ("Long Bow", "12", 2, 3), ("Recurve Bow", "12", 2, 4), 
    ("Hunting Bow", "8", 2, 5), ("Bec De Corbin", "20", 2, 6), ("Spear", "10", 2, 7),
    ("Mace", "10", 1, 8), ("Fist", "2", 1, 9)
   };

   public void PickUp()
   {

   }

   public int SetWeapon()
   {
    int count = 1;
    int userInput;

    foreach (var weapon in _weapons)
    {
        Console.Write($"{count})");
        Console.WriteLine(weapon.Item1);
        count += 1;
    }
    
    Console.WriteLine("");
    userInput = Convert.ToInt32(Console.ReadLine()) - 1;

    return _weapons[userInput].Item4;
    }

   public int Attack(int ind)
   {
      Dice dice1 = new Dice();
      int damage;
      var weapon = _weapons[ind];
      
      if (weapon.Item2 == "20")
      {
         damage = dice1.RollD20();
      }
      else if (weapon.Item2 == "12")
      {
         damage = dice1.RollD12();
      }
      else if (weapon.Item2 == "10")
      {
         damage = dice1.RollD10();
      }
      else if (weapon.Item2 == "8")
      {
         damage = dice1.RollD8();
      }
      else if (weapon.Item2 == "6")
      {
         damage = dice1.RollD6();
      }
      else if (weapon.Item2 == "4")
      {
         damage = dice1.RollD4();
      }
      else if (weapon.Item2 == "2")
      {
         damage = dice1.RollD2();
      }
      else
      {
         damage = 0;
      }

      return damage;
   }
}