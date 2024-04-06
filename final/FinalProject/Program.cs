using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Player player = new Player("Player", 100, 20, 5);
        CombatManager combat = new CombatManager();

        while (userInput != "4")
        {
            // Console.Clear();
            combat.Start();
            userInput = Console.ReadLine();

            /*
            Set conditions for user input
            */

            // Option 1 for fighting a Warrior
            if (userInput == "1")
            {
                Warrior warrior = new Warrior("Garen", 100, 10, 2);
                combat.PlayerTurn(player, warrior);
                combat.EnemyTurn(player, warrior);
                // make a loop to see who wins
            }

            // Option 2 for fighting a Rogue
            else if (userInput == "2")
            {   
                Rogue rogue = new Rogue("Ashe", 80, 20, 5);
                combat.PlayerTurn(player, rogue);
                combat.EnemyTurn(player, rogue);
            }

            // Option 3 for fighting a Mage
            else if (userInput == "3")
            {
                Mage mage = new Mage("Ryze", 60, 5, 10);
                combat.PlayerTurn(player, mage);
                combat.EnemyTurn(player, mage);
            }

            // Option 4 to quit
            else if (userInput == "4")
            {
                break;
            }

            // For any entry other than the ones listed in the menu
            else
            {
                Console.WriteLine("Not a valid input. Please try again by typing the number of the option you want.");
            }
        }
    }
}