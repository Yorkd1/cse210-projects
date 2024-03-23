using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // create breathing activity run through
    public void Run()
    {
        int t = 0;
        DisplayStartingMessage();
        SetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        while (t < _duration)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(2);
            Console.Write("\nNow breathe out... ");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.Write("\nNow breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
            t+=15;
        }   

        DisplayEndingMessage();
    }
}