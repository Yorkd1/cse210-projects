public abstract class Unit
{
    protected string _name;
    protected int _health;
    protected int _attackPower;
    protected int _healPower;

    public Unit(string name, int health, int attack, int heal)
    {
        _name = name;
        _health = health;
        _attackPower = attack;
        _healPower = heal;
    }

    public void Attack(Unit attackedUnit)
    {
        int attack = _attackPower;
        attackedUnit.DamageTaken(attack);
        Console.WriteLine($"> {_name} attacks {attackedUnit}, this attack deals {attack} damage.");
    }

    public void DamageTaken(int damage)
    {
        _health = _health - damage;
    }
    public void Heal()
    {
        _health += _healPower;
        Console.WriteLine($"> {_name} heals for {_healPower}");
    }

    public abstract void Ability();
    
}

