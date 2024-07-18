public class Wizard : Enemy
{
    public Wizard()
    {
        _health = 50;
        _strength = 12;
        _dexterity = 20;
        _armorClass = 0;
    }

    public override int Attack()
    {
        Dice dice = new Dice();

        int damageRoll = dice.RollD12();

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
        return "Wizard";
    }

    public int ReturnHealth()
    {
        return _health;
    }
}