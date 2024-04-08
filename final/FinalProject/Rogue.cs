public class Rogue : Unit
{


    public Rogue(string name, int health, int attack, int heal): base(name, health, attack, heal)
    {
        _name = name;
        _health = health;
        _attackPower = attack;
        _healPower = heal;
        _abilityCount = 1;
    }

    public override void Ability()
    {
       if (_abilityCount < 1)
        {
            Console.WriteLine($"{_name} tried to use her ability, but it failed.");
        }

       if (_abilityCount > 0)
        {
            Console.WriteLine($"{_name} choose to use her ability! She gains 10 attack power.");
            _abilityCount -= 1;
            _attackPower += 10;
            Console.WriteLine($"{_name} has {_abilityCount} abilities left.");
        }
    }
}