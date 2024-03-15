using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (userInput != "quit")
        {
            // display reference and scripture
            string refer = reference.GetDisplayText();
            string passage = scripture.GetDisplayText();
            bool allUnderScore;
            Console.WriteLine($"{refer} {passage}");
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            
            // consider different choices for userInput
            if (userInput == "")
            {
                // if user would like to continue memorizing
                Console.Clear();
                scripture.HideRandomWords(3);
                allUnderScore = scripture.IsCompletelyHidden();
                if (allUnderScore)
                {
                    break;
                }
            }

            // if user would like to quit
            else if (userInput == "quit")
            {
                break;
            }

            // if anything else other than enter or 'quit' is entered
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}