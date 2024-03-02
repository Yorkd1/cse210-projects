using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        // Get grade percentage from user
        Console.WriteLine("What is your grade percentage?");
        Console.WriteLine("A >= 90");
        Console.WriteLine("B >= 80");
        Console.WriteLine("C >= 70");
        Console.WriteLine("D >= 60");
        Console.WriteLine("F < 60");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        string letter = "";

        // Determine which letter grade the user should get
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        // See if user passes or not
        if (percentage >= 70)
        {
            Console.WriteLine("Yay you pass the class!");
        }
        else
        {
            Console.WriteLine("Don't worry, you'll pass next time.");
        }
    }
}