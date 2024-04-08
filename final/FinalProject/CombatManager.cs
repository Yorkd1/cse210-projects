using System.ComponentModel;
using System.Net;

public class CombatManager
{

    Random random = new Random();

    public void Start()
    {
        Console.WriteLine("\nOption Menu:");
        Console.WriteLine("1. Fight a Warrior.");
        Console.WriteLine("2. Fight a Rogue.");
        Console.WriteLine("3. Fight a Mage.");
        Console.WriteLine("4. Quit!");
        Console.Write("Which option would you like to select? ");

    }

    public void PlayerTurn(Unit player, Unit enemy)
    {
        
        Console.WriteLine("\nYour turn:");
        Console.WriteLine("Type 'a' to attack or 'h' to heal. If you want to use your ablility type 'z'.");
        string playerChoice = Console.ReadLine();

        if (playerChoice == "a")
        {
            player.Attack(enemy);
        }
        else if (playerChoice == "h")
        {
            player.Heal();
        }
        else if (playerChoice == "z")
        {
            player.Ability();
        }
        else
        {
            Console.WriteLine("Invalid Command!\n");
            return;
        }
    }

    public void EnemyTurn(Unit player, Unit enemy)
    {
        Console.WriteLine("\nEnemy turn:");
        int enemyChoice = random.Next(0, 3);

        if (enemyChoice == 0)
        {
            enemy.Attack(player);
        }

        else if (enemyChoice == 1)
        {
            enemy.Heal();
        }

        else if (enemyChoice == 2)
        {
            enemy.Ability();
        }
    }
}