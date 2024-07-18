using System;

public class Guard : Enemy
{
    public Guard()
    {
        _health = 20;
        _strength = 12;
        _dexterity = 11;
        _armorClass = 10;
    }

    public override int Attack()
    {
        Dice dice = new Dice();

        int damageRoll = dice.RollD10();

        return damageRoll;
    }

    public override int MakeAttack(int d20Roll, int playerArmor)
    {
        int attackRoll = d20Roll + _dexterity;

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
        return "Guard";
    }
}