using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Declare local variables
        string userInput = "";
        Journal journal = new Journal();
        

        while (userInput != "5")
        {
            //Provide user with option menu
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            /*
            Set conditions for user input
            */

            // Make a new journal entry
            if (userInput == "1")
            {
                Entry anEntry = new Entry();
                anEntry.Display();
                journal.AddEntry(anEntry); 
            }

            // Display journal entries
            else if (userInput == "2")
            {   
                journal.DisplayAll();
            }

            // Load journal entry from a file
            else if (userInput == "3")
            {
                Console.Write("Which file would you like to use? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            // Save journal entry to a file
            else if (userInput == "4")
            {
                Console.Write("What do you want to name your file? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            // Quit program
            else if (userInput == "5")
            {
                continue;
            }
            // For any entry that was not an option
            else
            {
                Console.WriteLine("Not a valid input. Please try again");
            }

        }
            
    }
}