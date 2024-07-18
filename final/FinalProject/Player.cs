using System;
using System.ComponentModel;

public class Player
{
    public Player()
    {}
    Weapon _playerWeapon = new Weapon();
    Dice _PlayerDice = new Dice();
    Items _playerItems = new Items();
    Armor _playerArmor = new Armor();
    private int _strength;
    private int _dexterity;
    private int _constitution;
    private int _intelligence;
    private int _maxHealth;
    private int _health;
    private int _armorClass;
    private int _gold;
    private bool _canSee = true;
    int _weapon;
    Tuple<int, int>[] _inventory = 
    {
        Tuple.Create(2, 0), Tuple.Create(2, 0),
        Tuple.Create(1, 0), Tuple.Create(1, 0) 
    };

     public void CreateCharacter()
    {
        int stat1;
        int stat2;
        int stat3;
        int stat4;
        string userInput;
        
        stat1 = _PlayerDice.RollD6() + _PlayerDice.RollD6() + _PlayerDice.RollD6();
        stat2 = _PlayerDice.RollD6() + _PlayerDice.RollD6() + _PlayerDice.RollD6();
        stat3 = _PlayerDice.RollD6() + _PlayerDice.RollD6() + _PlayerDice.RollD6();
        stat4 = _PlayerDice.RollD6() + _PlayerDice.RollD6() + _PlayerDice.RollD6();
        _gold = _PlayerDice.RollD20() * _PlayerDice.RollD20();

        Console.WriteLine("Which stat would you like to be your strength: ");
        Console.WriteLine($"1) {stat1}");
        Console.WriteLine($"2) {stat2}");
        Console.WriteLine($"3) {stat3}");
        Console.WriteLine($"4) {stat4}");
        Console.WriteLine("");
        userInput = Console.ReadLine();
        Console.Clear();
        
        if (userInput == "1")
        {
            _strength = stat1;

            Console.WriteLine("Which stat would you like to be your dexterity: ");
            Console.WriteLine($"1) {stat2}");
            Console.WriteLine($"2) {stat3}");
            Console.WriteLine($"3) {stat4}");
            Console.WriteLine("");
            userInput = Console.ReadLine();
            Console.Clear();
            
            if (userInput == "1")
            {
                _dexterity = stat2;

                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat3}");
                Console.WriteLine($"2) {stat4}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat4}");

                    _constitution = stat3;
                    _intelligence = stat4;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Your intelligence is {stat3}");

                    _constitution = stat4;
                    _intelligence = stat3;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (userInput == "2")
            {
                _dexterity = stat3;

                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat2}");
                Console.WriteLine($"2) {stat4}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat4}");

                    _constitution = stat2;
                    _intelligence = stat4;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Your intelligence is {stat2}");

                    _constitution = stat4;
                    _intelligence = stat2;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                _dexterity = stat4;

                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat2}");
                Console.WriteLine($"2) {stat3}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat3}");

                    _constitution = stat2;
                    _intelligence = stat3;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Your intelligence is {stat2}");

                    _constitution = stat3;
                    _intelligence = stat2;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        else if (userInput == "2")
        {
            _strength = stat2;

            Console.WriteLine("Which stat would you like to be your dexterity: ");
            Console.WriteLine($"1) {stat1}");
            Console.WriteLine($"2) {stat3}");
            Console.WriteLine($"3) {stat4}");
            Console.WriteLine("");
            userInput = Console.ReadLine();
            Console.WriteLine("");
            Console.Clear();

            if (userInput == "1")
            {
                _dexterity = stat1;

                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat3}");
                Console.WriteLine($"2) {stat4}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat4}");

                    _constitution = stat3;
                    _intelligence = stat4;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Your intelligence is {stat3}");

                    _constitution = stat4;
                    _intelligence = stat3;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if(userInput == "2")
            {
                _dexterity = stat3;

                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat1}");
                Console.WriteLine($"2) {stat4}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat4}");

                    _constitution = stat1;
                    _intelligence = stat4;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Your intelligence is {stat1}");

                    _constitution = stat4;
                    _intelligence = stat1;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                _dexterity = stat4;

                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat1}");
                Console.WriteLine($"2) {stat3}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat3}");

                    _constitution = stat1;
                    _intelligence = stat3;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Your intelligence is {stat1}");

                    _constitution = stat3;
                    _intelligence = stat1;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            
        }
        else if (userInput == "3")
        {
            _strength = stat3;

            Console.WriteLine("Which stat would you like to be your dexterity: ");
            Console.WriteLine($"1) {stat1}");
            Console.WriteLine($"2) {stat2}");
            Console.WriteLine($"3) {stat4}");
            Console.WriteLine("");
            userInput = Console.ReadLine();
            Console.Clear();

            if (userInput == "1")
            {
                _dexterity = stat1;
                
                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat2}");
                Console.WriteLine($"2) {stat4}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat4}");

                    _constitution = stat2;
                    _intelligence = stat4;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Your intelligence is {stat2}");

                    _constitution = stat4;
                    _intelligence = stat2;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (userInput == "2")
            {
                _dexterity = stat2;
                
                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat1}");
                Console.WriteLine($"2) {stat4}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat4}");

                    _constitution = stat1;
                    _intelligence = stat4;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Your intelligence is {stat1}");

                    _constitution = stat4;
                    _intelligence = stat1;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                _dexterity = stat4;

                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat1}");
                Console.WriteLine($"2) {stat2}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat2}");

                    _constitution = stat1;
                    _intelligence = stat2;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Your intelligence is {stat1}");

                    _constitution = stat2;
                    _intelligence = stat1;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        else
        {
            _strength = stat4;

            Console.WriteLine("Which stat would you like to be your dexterity: ");
            Console.WriteLine($"1) {stat1}");
            Console.WriteLine($"2) {stat2}");
            Console.WriteLine($"3) {stat3}");
            Console.WriteLine("");
            userInput = Console.ReadLine();
            Console.Clear();

            if (userInput == "1")
            {
                _dexterity = stat1;

                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat2}");
                Console.WriteLine($"2) {stat3}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat3}");

                    _constitution = stat2;
                    _intelligence = stat3;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else 
                {
                    Console.WriteLine($"Your intelligence is {stat2}");

                    _constitution = stat3;
                    _intelligence = stat2;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }


            }
            else if (userInput == "2")
            {
                _dexterity = stat2;

                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat1}");
                Console.WriteLine($"2) {stat3}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1" )
                {
                    Console.WriteLine($"Your intelligence is {stat3}");

                    _constitution = stat1;
                    _intelligence = stat3;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else 
                {
                    Console.WriteLine($"Your intelligence is {stat1}");

                    _constitution = stat3;
                    _intelligence = stat1;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                _dexterity = stat3;

                Console.WriteLine("Which stat would you like to be your constitution: ");
                Console.WriteLine($"1) {stat1}");
                Console.WriteLine($"2) {stat2}");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput == "1")
                {
                    Console.WriteLine($"Your intelligence is {stat2}");

                    _constitution = stat1;
                    _intelligence = stat2;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Your intelligence is {stat1}");

                    _constitution = stat2;
                    _intelligence = stat1;
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        Console.WriteLine("Please select what armor you would like to start with.");
        _armorClass = _playerArmor.SetArmor();
        Console.Clear();
        Console.WriteLine("Please select which weapon you would like.");
        int newWeapon = _playerWeapon.SetWeapon();
        _weapon = newWeapon;
        
        _maxHealth = _constitution * 4;
        _health = _maxHealth;

        Console.Clear();
    }

    public void SubtractHealth(int damage)
    {
        _health = _health - damage;
    }

    public void AddHealth(int healing)
    {
        _health = _health + healing;
        if (_health >= _maxHealth)
        {
            _health = _maxHealth;
        }
    }

    public void UseIteam()
    {
        int count = 1;
        int itemInput; 
        Tuple<int, int> itemToUse;
        foreach (var item in _inventory)
        {
            Console.Write($"{count}) ");
            _playerItems.ShowItems(item);
            count += 1;
        }

        Console.WriteLine("");
        count -= 1;
        itemInput = Convert.ToInt32(Console.ReadLine());

        if (itemInput <= count && itemInput >= 0)
        {
            itemInput -= 1;

            itemToUse = _inventory[itemInput];
            if (itemToUse.Item1 == 1)
            {
                AddHealth(_playerItems.UseIteam(itemToUse));
                // got following line from https://stackoverflow.com/questions/457453/remove-element-of-a-regular-array
                _inventory = _inventory.Where((source, index) => index != itemInput).ToArray();
            }
            else if (itemToUse.Item1 == 2)
            {
                _canSee = true;
                // got following line from https://stackoverflow.com/questions/457453/remove-element-of-a-regular-array
                _inventory = _inventory.Where((source, index) => index != itemInput).ToArray();
            }
            count -= 1;
        }
    }

    public Tuple<int, int> SellIteam()
    {
        int count = 1;
        int itemInput; 
        Tuple<int, int> itemToSell;
        foreach (var item in _inventory)
        {
            Console.Write($"{count}) ");
            _playerItems.ShowItems(item);
            count += 1;
        }

        Console.WriteLine("");
        count -= 1;
        itemInput = Convert.ToInt32(Console.ReadLine());

        if (itemInput <= count && itemInput >= 0)
        {
            itemInput -= 1;
            itemToSell = _inventory[itemInput];
            _inventory = _inventory.Where((source, index) => index != itemInput).ToArray();
            count -= 1;

            return itemToSell;
        }
        else
        {
            return Tuple.Create(0, 0);
        }
    }

    public void PickUpIteam(Tuple<int, int> item)
    {
        _inventory = _inventory.Append(item).ToArray();
    }

    public int Attack()
    {
        int attack = _playerWeapon.Attack(_weapon) + _strength;
        return attack;
    }

    public bool LightOrDark(bool isDark)
    {
        if (isDark == true)
        {
            _canSee = false;
            return _canSee;
        }
        else
        {
            _canSee = true;
            return _canSee;
        }
    }

    public int GetStrength()
    {
        return _strength;
    }

    public int GetDexterity()
    {
        return _dexterity;
    }

    public int GetConstitution()
    {
        return _constitution;
    }

    public int GetIntelligence()
    {
        return _intelligence;
    }

    public int GetMaxHealth()
    {
        return _maxHealth;
    }

    public int GetHealth()
    {
        return _health;
    }

    public int GetArmor()
    {
        return _armorClass;
    }

    public int GetGold()
    {
        return _gold;
    }

    public void SubtractGold(int cost)
    {
        _gold -= cost;
    }

    public void AddGold(int value)
    {
        _gold += value;
    }
    public bool GetCanSee()
    {
        return _canSee;
    }
}