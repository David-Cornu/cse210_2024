using System;

public class Goblin : Enemy
{
    public Goblin()
    {
        _health = 10;
        _strength = 10;
        _dexterity = 10;
        _armorClass = 8;
    }

    public override int Attack()
    {
        Dice dice = new Dice();

        int damageRoll = dice.RollD4();

        return damageRoll;
    }

    public override int MakeAttack(int d20Roll, int playerArmor)
    {
        int attackRoll = d20Roll;

        if (attackRoll >= playerArmor)
        {
            return Attack();
        }
        else
        {
            return 0;
        }
    }


    public override string GetEnemyType()
    {
        return "Goblin";
    }

}