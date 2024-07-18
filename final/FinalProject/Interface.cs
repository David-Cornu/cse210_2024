using System;
using System.Runtime.CompilerServices;

public class Interface
{
    Player _player = new Player();
    Items _items = new Items();
    Dice _dice = new Dice();
    private string _userInput;
    private int _attack;

    public void DisplayPlayerStats(Player player)
    {
        Console.WriteLine("---");
        Console.WriteLine($"Max HP: {player.GetMaxHealth()}");
        Console.WriteLine($"HP: {player.GetHealth()}");
        Console.WriteLine($"Armor: {player.GetArmor()}");
        Console.WriteLine($"Strength: {player.GetStrength()}");
        Console.WriteLine($"Dexterity: {player.GetDexterity()}");
        Console.WriteLine($"Constitution: {player.GetConstitution()}");
        Console.WriteLine($"Intelligence: {player.GetIntelligence()}");
        Console.WriteLine($"Gold: {player.GetGold()}");
        Console.WriteLine("---");
    }

    public void MultiAttack(Player player, Enemy enemy1, Enemy enemy2)
    {
        Console.WriteLine("");
        Console.WriteLine($"The {enemy1.GetEnemyType()} Attacks you.");
        _attack = enemy1.MakeAttack(_dice.RollD20(), _player.GetArmor());
        Console.WriteLine($"{enemy1.GetEnemyType()} delt {_attack} damage");
        player.SubtractHealth(_attack);
        Console.WriteLine($"The {enemy2.GetEnemyType()} Attacks you.");
        _attack = enemy2.MakeAttack(_dice.RollD20(), _player.GetArmor());
        Console.WriteLine($"{enemy2.GetEnemyType()} delt {_attack} damage");
        player.SubtractHealth(_attack);
        Console.WriteLine("");
        Console.ReadLine();
    }
    
    public void SingleAttack(Player player, Enemy enemy)
    {
        Console.WriteLine("");
        Console.WriteLine($"The {enemy.GetEnemyType()} Attacks you.");
        _attack = enemy.MakeAttack(_dice.RollD20(), player.GetArmor());
        Console.WriteLine($"the {enemy.GetEnemyType()} delt {_attack} damage.");
        Console.WriteLine("");
        player.SubtractHealth(_attack);
        Console.WriteLine("");
        Console.ReadLine();
    }

    public void DecisionCombat(Player player, Enemy enemy)
    {
        int enemyHealth = enemy.GetHealth();
        int playerHealth = player.GetHealth();

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine($"{enemy.GetEnemyType()} Hp: {enemy.GetHealth()}");
            DisplayPlayerStats(player);
            Console.WriteLine("What would you Like to Do?");
            Console.WriteLine("");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Use Item");
            Console.WriteLine("3) Leave");
            Console.WriteLine("");
            _userInput = Console.ReadLine();
            Console.WriteLine("");

            if (_userInput == "1")
            {
                _attack = _player.Attack();
                Console.WriteLine($"You delt {_attack} damage.");
                enemy.SubtractHealth(_attack);
                SingleAttack(player, enemy);
            }
            else if (_userInput == "2")
            {
                SingleAttack(player, enemy);
                Console.Clear();
                player.UseIteam();
            }
            else if (_userInput == "3")
            {
                enemy.SubtractHealth(100);
                Console.WriteLine("You got away.");
                Console.ReadLine();
            }

            enemyHealth = enemy.GetHealth();
            playerHealth = player.GetHealth();

            Console.Clear();
        }
    }

    public void DecisionCombat(Player player, Enemy enemy1, Enemy enemy2)
    {
        int enemy1Health = enemy1.GetHealth();
        int enemy2Health = enemy2.GetHealth();
        int playerHealth = player.GetHealth();

        while(playerHealth > 0 && enemy1Health > 0 && enemy2Health > 0)
        {
            Console.WriteLine("");
            Console.WriteLine($"{enemy1.GetEnemyType()} Hp: {enemy1.GetHealth()}");
            Console.WriteLine($"{enemy2.GetEnemyType()} Hp: {enemy2.GetHealth()}");
            DisplayPlayerStats(player);
            Console.WriteLine("What would you Like to Do?");
            Console.WriteLine("");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Use Item");
            Console.WriteLine("3) Leave");
            Console.WriteLine("");
            _userInput = Console.ReadLine();
            Console.WriteLine("");

            if (_userInput == "1")
            {
                Console.WriteLine("Which would you like to attack.");
                Console.WriteLine($"1) {enemy1.GetEnemyType()}");
                Console.WriteLine($"2) {enemy2.GetEnemyType()}");
                Console.WriteLine("");
                _userInput = Console.ReadLine();
                Console.WriteLine("");

                if (_userInput == "1")
                {
                    _attack = player.Attack();
                    Console.WriteLine($"You delt {_attack} damage.");
                    enemy1.SubtractHealth(_attack);
                    MultiAttack(player, enemy1, enemy2);
                }
                else
                {
                    _attack = _player.Attack();
                    Console.WriteLine($"You delt {_attack} damage.");
                    enemy2.SubtractHealth(_attack);
                    MultiAttack(player, enemy1, enemy2);
                }
                Console.Clear();
            }
            else if (_userInput == "2")
            {
                MultiAttack(player, enemy1, enemy2);
                Console.Clear();
                player.UseIteam();
                Console.Clear();
            }
            else if (_userInput == "3")
            {
                enemy1.SubtractHealth(100);
                enemy2.SubtractHealth(100);
                Console.WriteLine("You got away.");
                Console.ReadLine();
                Console.Clear();
            }
            
            enemy1Health = enemy1.GetHealth();
            enemy2Health = enemy2.GetHealth();
            playerHealth = player.GetHealth();
        }
        while (enemy1Health > 0 && enemy2Health <= 0 && playerHealth > 0 )
        {
            DecisionCombat(player, enemy1);
            enemy1Health = enemy1.GetHealth();
            enemy2Health = enemy2.GetHealth();
            playerHealth = player.GetHealth();
        }
        while (enemy1Health <= 0 && enemy2Health > 0 && playerHealth > 0 )
        {
            DecisionCombat(player, enemy2);
            enemy1Health = enemy1.GetHealth();
            enemy2Health = enemy2.GetHealth();
            playerHealth = player.GetHealth();
        }
    }

    public string DecisionNonCombat(Player player)
    {
        
        Console.WriteLine("");
        DisplayPlayerStats(player);
        Console.WriteLine("What would you Like to Do?");
        Console.WriteLine("");
        Console.WriteLine("1) Use Item");
        Console.WriteLine("");
        _userInput = Console.ReadLine();
        Console.WriteLine("");

        if(_userInput == "1")
        {
            player.UseIteam();
            Console.Clear();
            return "1";
        }
        else
        {
            Console.Clear();
            return "2";
        }
    }

    public string DecisionNonCombat(Player player, string option1, string option2)
    {
        bool run = true;

        while (run == true)
        {
            Console.WriteLine("");
            DisplayPlayerStats(player);
            Console.WriteLine("What would you Like to Do?");
            Console.WriteLine("");
            Console.WriteLine($"1) {option1}");
            Console.WriteLine($"2) {option2}");
            Console.WriteLine("3) Use Item");
            Console.WriteLine("");
            _userInput = Console.ReadLine();
            Console.WriteLine("");

            if(_userInput == "1")
            {
                run = false;
            }
            else if(_userInput == "2")
            {
                run = false;
            }
            else
            {
                player.UseIteam();
                Console.Clear();
            }
        }
        if(_userInput == "1")
        {
            Console.Clear();
            return "1";
        }
        else if(_userInput == "2")
        {
            Console.Clear();
            return "2";
        }
        else
        {
            Console.Clear();
            return "3";
        }
    }

    public string DecisionNonCombat(Player player, string option1, string option2, string option3)
    {
        Console.WriteLine("");
        DisplayPlayerStats(player);
        Console.WriteLine("What would you Like to Do?");
        Console.WriteLine("");
        Console.WriteLine($"1) {option1}");
        Console.WriteLine($"2) {option2}");
        Console.WriteLine($"3) {option3}");
        Console.WriteLine("4) Use Item");
        Console.WriteLine("");
        _userInput = Console.ReadLine();
        Console.WriteLine("");

        if(_userInput == "1")
        {
            Console.Clear();
            return "1";
        }
        else if(_userInput == "2")
        {
            Console.Clear();
            return "2";
        }
        else if (_userInput == "3")
        {
            Console.Clear();
            return "4";
        }
        else
        {
            Console.Clear();
            player.UseIteam();
            return "3";
        }
    }

    public void DecisionStore(Player player)
    {
        Tuple<int, int, int> itemToSell;
        // tuple is set up as (type, item, cost in gold)
        Tuple<int, int, int>[] storeItems = 
        {
            Tuple.Create(2, 0, 5), Tuple.Create(2, 0, 5),
            Tuple.Create(1, 0, 20), Tuple.Create(1, 0, 20),
            Tuple.Create(1, 0, 20), Tuple.Create(1, 0, 20),
            Tuple.Create(1, 0, 20), Tuple.Create(1, 0, 20)
        };

        while (_userInput != "4")
        {
            int playerGold = player.GetGold();
            int count = 1;

            Console.WriteLine("");
            DisplayPlayerStats(player);
            Console.WriteLine("What would you Like to Do?");
            Console.WriteLine("");
            Console.WriteLine($"1) Buy");
            Console.WriteLine($"2) Sell");
            Console.WriteLine("3) Use Item");
            Console.WriteLine("4) Leave");
            Console.WriteLine("");
            _userInput = Console.ReadLine();
            Console.WriteLine("");
            Console.Clear();

            if(_userInput == "1")
            {
                foreach (var item in storeItems)
                {
                    Console.Write($"{count}) ");
                    Tuple<int, int> useableItem = Tuple.Create(item.Item1, item.Item2);
                    _items.ShowItems(useableItem);
                    count += 1;
                }
                Console.WriteLine("");
                count -= 1;
                int itemInput = Convert.ToInt32(Console.ReadLine());

                if (itemInput <= count && itemInput >= 0)
                {
                    itemInput -= 1;

                    itemToSell = storeItems[itemInput];
                    
                    // got following line from https://stackoverflow.com/questions/457453/remove-element-of-a-regular-array
                    storeItems = storeItems.Where((source, index) => index != itemInput).ToArray();
                    count -= 1;
                    if ((playerGold - itemToSell.Item3) > -1 )
                    {
                        player.SubtractGold(itemToSell.Item3);
                        Tuple<int, int> boughtItem = Tuple.Create(itemToSell.Item1, itemToSell.Item2);
                        player.PickUpIteam(boughtItem);
                        player.SubtractGold(itemToSell.Item3);
                        playerGold = player.GetGold();
                    }
                }
                Console.Clear();
            }
            else if(_userInput == "2")
            {
                Tuple<int, int> soldPlayerItem;
                Tuple<int, int, int> ItemAddedToShop;

                soldPlayerItem = player.SellIteam();
                ItemAddedToShop = Tuple.Create(soldPlayerItem.Item1, soldPlayerItem.Item2, 20);
                storeItems = storeItems.Append(ItemAddedToShop).ToArray();

                player.AddGold(5);
                Console.Clear();
            }
            else if (_userInput == "3")
            {
                player.UseIteam();
                Console.Clear();
            }
        }   
    }

    public void DecisionTavern(Player player)
    {
        bool run = true;
        
        while (run == true)
        {
            Console.WriteLine("");
            int playerGold = player.GetGold();
            DisplayPlayerStats(player);
            Console.WriteLine("What would you Like to Do?");
            Console.WriteLine("");
            Console.WriteLine($"1) Buy Drink");
            Console.WriteLine($"2) Talk to Bar tender");
            Console.WriteLine("3) Use Item");
            Console.WriteLine("4) Leave");
            Console.WriteLine("");
            _userInput = Console.ReadLine();
            Console.WriteLine("");
            Console.Clear();

            if (_userInput == "1")
            {
                if ((playerGold - 2) > -1)
                {
                    player.SubtractGold(2);
                    Console.WriteLine("You bought a drink at the tavern.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You don't have enough gold.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (_userInput == "2")
            {
               _userInput = DecisionNonCombat(player, "Ask about the Wizard", "Ask about the town");

                if (_userInput == "1")
                {
                    Console.WriteLine("The Bar tender told you how the Wizard was forced out of the village.");
                    Console.WriteLine("Which the Bar tender thought was sad because the Wizard helped rebuild the town after the dragon attack.");
                    Console.WriteLine("The Bar tender suggested trying to find a way other than combat to deal with the Wizard.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (_userInput == "2")
                {
                    Console.WriteLine("The Bar tender told you that the village had been here for several generations.");
                    Console.WriteLine("However none of the current buildings are nearly that old.");
                    Console.WriteLine("The reason being that the village was recently attacked by a dragon.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (_userInput == "3")
            {
                Console.Clear();
                player.UseIteam();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                run = false;
            }
        }
    }

}