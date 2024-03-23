using System;

public class Activity
{
    // set member variables
    protected string _name;
    protected string _description;
    protected int _duration;
    

    public Activity()
    {
    
    }
    
    // create Starting Display method
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    // set duration member variable
    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    // create Ending Message method
    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well Done!!");
        Console.WriteLine("");
        ShowSpinner(5);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.\n");
        ShowSpinner(5);
    }

    // create spinner method 
    public void ShowSpinner(int seconds)
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        List<string> spinner = new List<string>();
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        

        while (DateTime.Now < end)
        {
            
            foreach (string i in spinner)
            {    
                Console.Write(i);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            
        }

    }

    // create Countdown method
    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
        
        
        for ( int i = seconds; i > 0; i--)
        {
            
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}}