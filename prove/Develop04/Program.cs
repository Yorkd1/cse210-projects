using System;

class Program
{
    static void Main(string[] args)
    {
         string userInput = "";
        

        while (userInput != "4")
        {
            //Provide user with option menu
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            /*
            Set conditions for user input
            */

            // Option 1 for breathing activity
            if (userInput == "1")
            {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

            // Option 2 for reflection activity
            else if (userInput == "2")
            {   
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }

            // Option 3 for listing activity
            else if (userInput == "3")
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }


            // Quit program
            else if (userInput == "4")
            {
                break;
            }
            
            else
            {
                Console.WriteLine("Not a valid input. Please try again by typing the number of the option you want.");
            }

    }
}}