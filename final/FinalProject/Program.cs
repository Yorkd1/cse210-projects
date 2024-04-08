using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Player player = new Player("Player", 100, 20, 5);
        CombatManager combat = new CombatManager();
        Spinner spinner= new Spinner();
        Console.WriteLine("Welcome to Unit Clash!");


        while (userInput != "4")
        {
            combat.Start();
            userInput = Console.ReadLine();

            /*
            Set conditions for user input
            */

            // Option 1 for fighting a Warrior
            if (userInput == "1")
            {
                Warrior warrior = new Warrior("Garen", 100, 10, 2);
                while (!player.IsDead && !warrior.IsDead)
                {
                    combat.PlayerTurn(player, warrior);
                    spinner.ShowSpinner(3);
                    combat.EnemyTurn(player, warrior);
                }
                Console.Clear();
                Console.WriteLine($"Congratulations! You beat the warrior, {warrior.Name}.");
            }

            // Option 2 for fighting a Rogue
            else if (userInput == "2")
            {   
                Rogue rogue = new Rogue("Ashe", 80, 20, 5);
                while (!player.IsDead && !rogue.IsDead)
                {
                    combat.PlayerTurn(player, rogue);
                    spinner.ShowSpinner(3);
                    combat.EnemyTurn(player, rogue);
                }
                Console.Clear();
                Console.WriteLine($"Congratulations! You beat the rogue, {rogue.Name}.");
            }

            // Option 3 for fighting a Mage
            else if (userInput == "3")
            {
                Mage mage = new Mage("Ryze", 60, 5, 10);
                while (!player.IsDead && !mage.IsDead)
                {
                    combat.PlayerTurn(player, mage);
                    spinner.ShowSpinner(3);
                    combat.EnemyTurn(player, mage);
                }
                Console.Clear();
                Console.WriteLine($"Congratulations! You beat the mage, {mage.Name}.");
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