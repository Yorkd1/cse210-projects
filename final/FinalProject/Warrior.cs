public class Warrior : Unit
{


    public Warrior(string name, int health, int attack, int heal): base(name, health, attack, heal)
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
            Console.WriteLine($"{_name} tried to use his ability, but it failed.");
        }

        if (_abilityCount > 0)
        {
            Console.WriteLine($"{_name} choose to use his ability! He gains 100 health.");
            _abilityCount -= 1;
            _health += 100;
            Console.WriteLine($"{_name} has {_abilityCount} abilities left.");
        }
    }
}