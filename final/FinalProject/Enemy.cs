using System;

public abstract class Enemy
{
    protected int _health;
    protected int _strength;
    protected int _dexterity;
    protected int _armorClass;

    public Enemy()
    {}

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }

    public abstract int Attack();

    public abstract int MakeAttack(int d20Roll, int playerArmor);

    public int GetArmor()
    {
        return _armorClass;
    }

    public int GetHealth()
    {
        return _health;
    }

    public abstract string GetEnemyType();

    public void SubtractHealth(int damage)
    {
        _health = _health - damage;
    }
}