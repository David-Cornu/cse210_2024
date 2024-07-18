public class Dragon : Enemy
{
    public Dragon()
    {
        _health = 80;
        _strength = 16;
        _dexterity = 10;
        _armorClass = 18;
    }

    public override int Attack()
    {
        Dice dice = new Dice();

        int damageRoll = dice.RollD20();

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
        return "Dragon";
    }
}