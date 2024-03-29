using System;

class Program
{
    static void Main(string[] args)
    {
         string userInput = "";
        
        GoalManager quest = new GoalManager();

        while (userInput != "6")
        {
            quest.Start();
            userInput = Console.ReadLine();

            /*
            Set conditions for user input
            */

            // Option 1 for creating goals
            if (userInput == "1")
            {
                quest.CreateGoal();
            }

            // Option 2 for displaying user's goals
            else if (userInput == "2")
            {   
                quest.ListGoalDetails();
            }

            // Option 3 for saving goals to a file
            else if (userInput == "3")
            {
                quest.SaveGoals();
            }

            // Option 4 for loading goals from an existing file
            else if (userInput == "4")
            {
                quest.LoadGoals();
            }
            
            // Option 5 for recording events done by user
            else if (userInput == "5")
            {
                quest.RecordEvent();
            }

            // Quit the program
            else if (userInput == "6")
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