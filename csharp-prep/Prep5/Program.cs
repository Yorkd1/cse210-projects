using System;

class Program
{
    static void Main(string[] args)
    {
    // DisplayWelcome function
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // PromptUserName function
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // PromptUserNumber function
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    // SquareNumber function
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // DisplayResult function
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }

    // Call functions
    DisplayWelcomeMessage();

    string userName = PromptUserName();
    int userNumber = PromptUserNumber();

    int squareNumber = SquareNumber(userNumber);

    DisplayResult(userName, squareNumber);
    }
}