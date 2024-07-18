using System;
using System.Net.Http.Headers;
using System.Security.Principal;

public class Story
{
    private Player _player = new Player();
    private Goblin _goblin1 = new Goblin();
    private Goblin _goblin2 = new Goblin();
    private Goblin _goblin3 = new Goblin();
    private Guard _guard1 = new Guard();
    private Guard _guard2 = new Guard();
    private Guard _guard3 = new Guard();
    private Guard _guard4 = new Guard();
    private Wizard _wizard = new Wizard();
    private Dragon _dragon = new Dragon();
    private Interface _interface = new Interface();
    private Dice _dice = new Dice();
    private int _attack;
    private int _playerHealth;
    private string _userInput;
    private bool _isDark;

    

    public void StoryStart()
    {
        Console.Clear();

        _player.CreateCharacter();
        
        Console.Clear();

        _playerHealth = _player.GetHealth();

        while (_playerHealth > 0)
        {
            Console.WriteLine("You are walking in a forest enjoying the shade from the trees");
            Console.WriteLine("As you walk you see a destroyed wagon.");
            Console.WriteLine("Approaching the wagon A goblin appeared, attempting to attack you.");
        
            _interface.DecisionCombat(_player, _goblin1);

            _playerHealth = _player.GetHealth();

            if (_playerHealth <= 0)
            {
                break;
            } 
  
            Console.WriteLine("With the goblin no longer attacking you see that the wagon belonged to a merchant.");
            Console.WriteLine("you see a trail of blood leading deeper into the forest.");
        
            _userInput = _interface.DecisionNonCombat(_player, "Follow the path to potentially save the merchant", "Continue on the path minding your own business");
        

            if (_userInput == "1")
            {
                Console.WriteLine("Following the trail of blood it leads into a cave.");
                Console.WriteLine("Entering the cave, you can only see around the entrance.");
            
                _isDark = true;
                _player.LightOrDark(_isDark);

                _userInput = _interface.DecisionNonCombat(_player, "Continue deeper into the cave", "Leave the cave. Leaving whatever remains of the merchant to its fate");
            
                if (_userInput == "1")
                {
                    while (_player.GetCanSee() == false)
                    {
                        Console.WriteLine("You are unable to see.");
                        Console.WriteLine("Something is attacking you.");
                        _attack = _goblin2.MakeAttack(_dice.RollD20(), _player.GetArmor()) + _goblin3.MakeAttack(_dice.RollD20(), _player.GetArmor());
                        Console.WriteLine($"Something delt {_attack} damage to you.");
                        _player.SubtractHealth(_attack);
                        _interface.DecisionNonCombat(_player);

                        _playerHealth = _player.GetHealth();

                        if (_playerHealth <= 0)
                        {
                            break;
                        }
                    }

                    _playerHealth = _player.GetHealth();

                    if (_playerHealth <= 0)
                    {
                        break;
                    }

                    _interface.DecisionCombat(_player, _goblin2, _goblin3);

                    _playerHealth = _player.GetHealth();

                    if (_playerHealth <= 0)
                    {
                        break;
                    }

                    Console.WriteLine("You find the merchant shaking on the ground.");
                    Console.WriteLine("You see that the merchant has some deep wounds.");
                    Console.WriteLine("With some help the merchant should be able to make it to the village.");

                    _userInput = _interface.DecisionNonCombat(_player, "Help the merchant to the village.", "Leave the merchant to slowly die.");

                    if(_userInput == "1")
                    {
                        Console.WriteLine("As you help the merchant up the merchant the merchant said, 'Thank you,'");
                        Console.WriteLine("The merchant told you there should still be something in his wagon that you could find useful.");
                        Console.WriteLine("In the wagon you found 5 health potions");
                        Console.WriteLine("You also find 50 gold");
                        Console.WriteLine("The merchant asked for one and said you could keep the rest and the gold.");
                        _player.PickUpIteam(Tuple.Create(1,0));
                        _player.PickUpIteam(Tuple.Create(1,0));
                        _player.PickUpIteam(Tuple.Create(1,0));
                        _player.PickUpIteam(Tuple.Create(1,0));
                        _player.AddGold(50);
                    }
                    else
                    {
                        Console.WriteLine("As you leave you hear the merchaint whimper in the darkness.");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("You head for the village.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("You make your way back to the trail.");
                }
            }
            else
            {
                Console.WriteLine("You make your way to the village you were wanting to visit.");
                break;
            }
        }   

        _playerHealth = _player.GetHealth();

        if(_playerHealth <= 0)
        {
            Console.WriteLine("Game Over");
        }     
    }

    public void Chapter2()
    {
        _player.AddHealth(100);
        Console.WriteLine("The village is small. With only a few building.");
        Console.WriteLine("As you look over the village you begin to wonder if there is even an inn.");
        Console.WriteLine("As you walk Through the village you hear people talk about a wizard causing problems.");
        Console.WriteLine("");

        Town();

        WizardTower();
    }

    public void Town()
    {
        bool run = true;
        while (run == true)
        {
            _userInput = _interface.DecisionNonCombat(_player, "Explore the village more", "Head to find the wizard");
            Console.Clear();
            if (_userInput == "1")
            {
                _userInput = _interface.DecisionNonCombat(_player, "Enter a shop you spotted", "Enter the tavern you see", "Head to find the wizard");
                Console.Clear();

                if (_userInput == "1") 
                {
                    _interface.DecisionStore(_player);
                    Console.Clear();
                }
                else if(_userInput == "2")
                {
                    _interface.DecisionTavern(_player);
                }
                else
                {
                    run = false;
                }
            }
            else
            {
                run = false;
            }
        }
    }

    public void WizardTower()
    {
        _playerHealth = _player.GetHealth();
        
        while (_playerHealth > 0)
        {
            Console.WriteLine("The Wizard Tower overlooks the village.");
            Console.WriteLine("The tower is built out of wood, and appears to have been built recently");
            Console.WriteLine("Two guards stand guarding the entrance");
        
            _userInput = _interface.DecisionNonCombat(_player, "Approach the guards and talk to them", "Attack the guards");

            Console.Clear();

            if (_userInput == "1")
            {
                Console.WriteLine("The guards seem confused that you are approaching them.");
                Console.WriteLine("One of the guards asks what business you have at the tower");
                
                _userInput = _interface.DecisionNonCombat(_player,
                "Say you head people in the village taking about a wizard harming the village and that you wanted to help clear things up",
                "Say you came to end the villages suffering by killing the wizard");


                if (_userInput == "1")
                {
                    Console.WriteLine("The guards look at each other in confusion.");

                    if(_player.GetIntelligence() >= 5)
                    {
                        Console.WriteLine("It's clear to you that they are not used to people approaching wanting to help.");
                        Console.WriteLine("You realize you might actually be able to help settle everything nonviolently.");
                    }
                    else
                    {
                        Console.WriteLine("You don't understand why they are confused.");
                        Console.WriteLine("You begin to think maybe the villagers are right to be scared of the wizard.");
                    }
                    
                    _userInput = _interface.DecisionNonCombat(_player, "Ask if you can speak with the wizard", "Attack the Guards");

                    
                    if (_userInput == "1")
                    {
                        NonCombatitiveWizardAproch();

                        break;
                    }
                    else if (_userInput == "2")
                    {
                        _interface.DecisionCombat(_player, _guard1, _guard2);
                            _playerHealth = _player.GetHealth();
                        if (_playerHealth <= 0)
                        {
                            break;
                        }

                        CombatitiveWizardAproch();

                        break;
                    }
                }
                else if (_userInput == "2")
                {
                    _interface.DecisionCombat(_player, _guard1, _guard2);
                    _playerHealth = _player.GetHealth();
                    if (_playerHealth <= 0)
                    {
                        break;
                    }
                    
                    CombatitiveWizardAproch();

                    break;
                }
            }
            else if (_userInput == "2")
            {
                _interface.DecisionCombat(_player, _guard1, _guard2);
                _playerHealth = _player.GetHealth();

                if (_playerHealth <= 0)
                {
                    break;
                }
                CombatitiveWizardAproch();

                break;
            }
        }

        if (_playerHealth <= 0)
        {
            Console.WriteLine("Game Over");
            Console.WriteLine("");
            Console.ReadLine();

            Console.Clear();
        }
    }

    public void NonCombatitiveWizardAproch()
    {
        Console.Clear();

        _playerHealth = _player.GetHealth();

        while (_playerHealth > 0)
        {
            Console.WriteLine("The wizard stands before you with two more guards standing on ether side of him.");
            Console.WriteLine("The wizard said he appreciated you wanting to talk instead of attacking.");
            Console.WriteLine("He continued about how he was asked to come to this village because a dragon had started attacking.");
            Console.WriteLine("Also due to his unfortunate lack of skill with weapons he was unable to slay the dragon");
            Console.WriteLine("Using his magic he was able to capture the dragon so it is stuck on the mountain.");
            Console.WriteLine("The wizard asked if you would kill the dragon so he could leave this village and return home.");

            _userInput = _interface.DecisionNonCombat(_player, "Agree to slay the dragon", "Leave", "Attack");

            if (_userInput == "1")
            {
                Console.WriteLine("The wizard tells you where the dragon is imprisoned");
                Console.WriteLine("Knowing you are heading into a dangerous battle the wizard gives you 5 healing potions");

                _player.PickUpIteam(Tuple.Create(1,0));
                _player.PickUpIteam(Tuple.Create(1,0));
                _player.PickUpIteam(Tuple.Create(1,0));
                _player.PickUpIteam(Tuple.Create(1,0));
                _player.PickUpIteam(Tuple.Create(1,0));

                Console.WriteLine("");
                Console.ReadLine();

                DragonBattle();

                break;
            }
            else if (_userInput == "2")
            {
                Console.WriteLine("You leave the wizard and the village to their own devises");
                Console.WriteLine("");

                Console.ReadLine();

                break;
            }
            else
            {
                Console.WriteLine("You lunge at the wizard.");
                Console.WriteLine("Before you were able to land your attack the two guards stepped in to protect the wizard.");

                _interface.DecisionCombat(_player, _guard3, _guard4);



                if(_player.GetHealth() <= 0)
                {
                    break;
                }

                Console.WriteLine("As the last guard falls there is no one standing between you or the wizard.");
                Console.WriteLine("You lunge at the wizard once more");

                _interface.DecisionCombat(_player, _wizard);

                if(_player.GetHealth() <= 0)
                {
                    break;
                }

                Console.WriteLine("As the wizard falls you hear the roar of a dragon.");
                Console.WriteLine("As you head for the tower door to see if the dragon is attacking you find the guards at the door.");
                Console.WriteLine("The guards look angry because letting you past caused them to fail at their task of guarding the wizard.");
                Console.WriteLine("The guards lunge at you.");

                _interface.DecisionCombat(_player, _guard1, _guard2);

                if(_player.GetHealth() <= 0)
                {
                    break;
                }

                Console.WriteLine("Leaving the tower you see smoke coming from the village.");
                Console.WriteLine("Over head you see the dragon flying toward the top of the mountain.");

                _userInput = _interface.DecisionNonCombat(_player, "Follow the dragon", "Leave");

                if (_userInput == "1")
                {
                    Console.WriteLine("You head to where the dragon flew to.");
                    Console.WriteLine("You may have caused the village to burn but you can at least let the people of it rebuild in peace.");

                    Console.WriteLine("");

                    Console.ReadLine();

                    DragonBattle();
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Deciding you don't want to fight a dragon you leave.");
                    Console.WriteLine("Knowing your actions lead to the destruction of the village doesn't seem to bother you.");
                    Console.WriteLine("As you get farther from the village the screams and cries get quieter.");
                    Console.WriteLine("");

                    Console.ReadLine();

                    break;
                }
            }
        }
    }

    public void CombatitiveWizardAproch()
    {
        Console.Clear();

        _playerHealth = _player.GetHealth();

        while (_playerHealth > 0)
        {
            Console.WriteLine("After fighting your way through the door two more guards run toward you.");
            Console.WriteLine("The guards yell as they charge you.");

            _interface.DecisionCombat(_player, _guard3, _guard4);

            _playerHealth = _player.GetHealth();

            if (_playerHealth <= 0)
            {
                break;
            }

            Console.Clear();

            Console.WriteLine("As the last guard falls you see the wizard looking at you with shock plastered on his face.");
            Console.WriteLine("The wizard asked you to stop your attack and listen");

           _userInput = _interface.DecisionNonCombat(_player, "Stop your attack and hear what the wizard has to say",
            "Continue your attack");

            if (_userInput == "1")
            {
                Console.WriteLine("The Wizard thanks you for listening.");
                Console.WriteLine("He continued to explain that even after being banished from the village he continued to hold the dragon at bay.");
                Console.WriteLine("He asked if you would slay the dragon.");
                Console.WriteLine("The wizard concluded with once the dragon is dead he plans on leaving not wanting to be somewhere that hates him.");

                _userInput = _interface.DecisionNonCombat(_player, "Agree to slay the dragon", "Finish off the wizard", "leave");

                if (_userInput == "1")
                {
                    Console.WriteLine("The wizard thanks you.");
                    Console.WriteLine("He tells you where the dragon is hiding");
                    Console.WriteLine("You head to where the dragon is hiding.");

                    Console.ReadLine();
                    
                    DragonBattle();

                    break;
                }
                else if (_userInput == "2")
                {
                    _interface.DecisionCombat(_player, _wizard);

                    Console.WriteLine("As the wizard falls to the ground you see sadness on his face.");
                    Console.WriteLine("As the wizard lays dead on the ground you hear the roar of the dragon.");
                    Console.WriteLine("Heading out side you see the dragon circling overhead.");
                    Console.WriteLine("Seeing the plume of smoke coming from the village you notice the dragon heading back to the mountain.");

                    _userInput = _interface.DecisionNonCombat(_player, "Follow the dragon", "Leave");

                    if (_userInput == "1")
                    {
                        DragonBattle();

                        break;
                    }
                    else
                    {
                        Console.WriteLine("You Leave the village to fend for itself.");

                        Console.ReadLine();

                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Deciding to not kill the wizard you leave");
                    Console.WriteLine("if the Wizard is telling the truth about a dragon, then it’s probably best to not get involved.");

                    Console.ReadLine();
                }
            }
            else 
            {
                _interface.DecisionCombat(_player, _wizard);

                break;
            }
        }
    }

    public void DragonBattle()
    {
        Console.Clear();

        _playerHealth = _player.GetHealth();

        while (_playerHealth > 0)
        {
            Console.WriteLine("You head up the mountain to the dragons layer.");
            Console.WriteLine("If you live through this you will have a story to tell that few will believe.");
            Console.WriteLine("You make your way to the cave the dragon uses as its layer");

            _userInput = _interface.DecisionNonCombat(_player, "Head into the cave", "leave");

            if (_userInput == "1")
            {
                _isDark = true;
                _player.LightOrDark(_isDark);

                while (_player.GetCanSee() == false)
                {
                    Console.WriteLine("You are unable to see.");
                    Console.WriteLine("the dragon attacked you.");
                    _attack = _dragon.MakeAttack(_dice.RollD20(), _player.GetArmor());
                    Console.WriteLine($"The dragon delt {_attack} damage to you.");
                    _player.SubtractHealth(_attack);
                    _interface.DecisionNonCombat(_player);

                    _playerHealth = _player.GetHealth();

                    if (_playerHealth <= 0)
                    {
                        break;
                    }
                }

                _interface.DecisionCombat(_player, _dragon);

                _playerHealth = _player.GetHealth();

                if (_playerHealth <= 0)
                {
                    break;
                }

                if (_wizard.ReturnHealth() > 0)
                {
                    Console.WriteLine("You return to the wizard and tell him that the dragon is dead.");
                    Console.WriteLine("The wizard thanks you and begins to pack.");
                    Console.WriteLine("You head to the village and tell them that the dragon is dead and that the wizard is going to leave the village.");
                    Console.WriteLine("");
                    
                    Console.ReadLine();

                    Console.Clear();
                    
                    break;
                }
                else
                {
                    _userInput = _interface.DecisionNonCombat(_player, "Help rebuild the village", "leave");

                    if (_userInput == "1")
                    {
                        Console.WriteLine("You tell the villager that the wizard and the dragon are dead.");
                        Console.WriteLine("You conclude by telling them that you want to help rebuild the village before you leave.");
                        Console.WriteLine("");

                        Console.ReadLine();

                        Console.Clear();

                        break;
                    }
                    else
                    {
                        Console.WriteLine("You decide to leave the village in fear of the dragon.");
                        Console.WriteLine("You have a new trophy so that is all that matters to you.");
                        Console.WriteLine("");

                        Console.ReadLine();

                        Console.Clear();

                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("You decide nothing is worth attempting to kill a dragon.");
                Console.WriteLine("You decide you don't care what happens to the village and leave.");
                Console.WriteLine("");

                Console.ReadLine();

                Console.Clear();

                break;
            }
        }
    }
}