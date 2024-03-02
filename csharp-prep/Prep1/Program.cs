using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        // Get first name of user
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Get last name of user
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Use first-name and last-name to write string
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}