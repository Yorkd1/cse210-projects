using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //Create list of user generated numbers
        List<int> numbers = new List<int>();
        int userNumber = -1;
        int sum = 0;
        int max = 0;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        
        }
        // Figure the sum of user list
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Your sum is {sum}");

        // Figure the average of user list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Your average is {average}");

        // Figure the greatest number in user list
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"Your max is {max}");
    }
}