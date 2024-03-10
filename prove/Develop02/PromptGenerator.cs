using System;

public class PromptGenerator
{
    // Make a list for journal prompts
    public List<string> _prompts = new List<string>();

    // Provide prompts for user
    public PromptGenerator()
    {
    _prompts.Add("Write about a person who has had a significant impact on your life and why.");
    _prompts.Add("Discuss a book, movie, or piece of art that deeply resonated with you and why it had such an impact.");
    _prompts.Add("Reflect on a moment of personal growth or self-discovery you've experienced recently.");
    _prompts.Add("Write about a time when you had to make a difficult decision and how it affected you.");
    _prompts.Add("Discuss a hobby or interest you're passionate about and why it brings you joy.");
    _prompts.Add("Reflect on a time when you felt grateful or appreciative and why.");
    }

    // generate random prompt
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(0, _prompts.Count);
        string prompt = _prompts[randomIndex];
        return prompt;
    }

}