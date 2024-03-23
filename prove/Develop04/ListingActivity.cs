using System;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    // create list of listing activity prompts
    private List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    
    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayListingPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        GetUserEntries(_duration);
        DisplayEndingMessage();

    }

    public string GetListingPrompt()
    {
        Random rand = new Random();
        int i = rand.Next(listingPrompts.Count);
        return listingPrompts[i];
    }

    public void DisplayListingPrompt()
    {
        Console.WriteLine($"---{GetListingPrompt()}---");
    }

    public void GetUserEntries(int seconds)
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        int count = 0;

        while (DateTime.Now < end)
        {
            
            Console.Write(">");
            string answer = Console.ReadLine();
            count += 1;
        }

        if (count >= 1)
        {
            Console.WriteLine("");
            Console.WriteLine($"You listed {count} items!");
        }

        else 
        {
            Console.WriteLine("");
            Console.WriteLine($"You listed {count} items!");
        }
    }
}