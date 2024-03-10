using System;


public class Entry
{
    // Make variables
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    public void Display()
    {
        // For journal entry: enter date, give prompt, and enter text
        Console.Write("Enter the date: ");
        _date = Console.ReadLine();
        PromptGenerator randomPrompt = new PromptGenerator();
        _promptText = randomPrompt.GetRandomPrompt();
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
    
    }
}