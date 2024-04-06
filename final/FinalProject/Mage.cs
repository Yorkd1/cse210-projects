public class Mage : Unit
{


    public Mage(string name, int health, int attack, int heal): base(name, health, attack, heal)
    {
        _name = name;
        _health = health;
        _attackPower = attack;
        _healPower = heal;
    }

    public override void Ability()
    {
        
    }
}