public class Player : Unit
{


    public Player(string name, int health, int attack, int heal): base(name, health, attack, heal)
    {
        _name = name;
        _health = health;
        _attackPower = attack;
        _healPower = heal;
        _abilityCount = 2;
    }

    public override void Ability()
    {
        if (_abilityCount < 1)
        {
            Console.WriteLine("You ran out of abilities to use.");
        }

        if (_abilityCount > 0)
        {
            Console.WriteLine("You choose to use your ability! You gain 100 health, 10 attack, and 10 heal power.");
            _abilityCount -= 1;
            _health += 100;
            _attackPower += 10;
            _healPower += 10;
            Console.WriteLine($"You have {_abilityCount} abilities left.");
        }
    }
}