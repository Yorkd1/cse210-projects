using System;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        //Provide user with option menu
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            
    }

// List goals the user made for completion
    public void ListGoalNames()
    {
        int count = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal name in _goals)
        {
            Console.WriteLine($"{count}) {name}");
            count += 1;
        }
    }

// List goals when user asks for them
    public void ListGoalDetails()
    {
        int count = 1;
        Console.WriteLine("\nThe goals are: ");
        foreach (Goal goal in _goals) 
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count += 1;
        }
    }

// first option to create type of goal
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("Write a short description of this goal: ");
        string description = Console.ReadLine();
        Console.Write("How many points would you give for completeing this goal? ");
        string points = Console.ReadLine();

        if (goalType == "1")
            {
                SimpleGoal simple = new SimpleGoal(shortName, description, points);
                _goals.Add(simple);
            }
            else if (goalType == "2")
            {
                EternalGoal eternal = new EternalGoal(shortName, description, points);
                _goals.Add(eternal);
            }
            else if (goalType == "3")
            {
                Console.Write("How many times does this goal need to be accomplished? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write($"What should be the bonus for completeing it {target} time(s)? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklist = new ChecklistGoal(shortName, description, points, target, bonus);
                _goals.Add(checklist);
            }
    }

// User completion for thier goals
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which Goal did you accomplish? ");
        int goalCompleted = int.Parse(Console.ReadLine());
        _goals[goalCompleted - 1].RecordEvent();
        int earnedPoints = _goals[goalCompleted - 1].GetPoints();
        _score += earnedPoints; 
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");

    }

// Save goal list to a file
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string file= Console.ReadLine();

        using(TextWriter tw = new StreamWriter(file)) 
        {
            tw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                tw.WriteLine(g.GetStringRepresentation());
            }
        }
    }

// Load goal list from a file
    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        _score = int.Parse(lines.First());
        string[] text = lines.Skip(1).ToArray();
        foreach(string line in text)
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string details = parts[1];
            string[] part = details.Split(",");
            if (goalType == "Simple Goal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(part[0], part[1], part[2]);
                _goals.Add(simpleGoal);
            } 
            else if (goalType == "Eternal Goal")
            {
                EternalGoal eternalGoal = new EternalGoal(part[0], part[1], part[2]);    
                _goals.Add(eternalGoal);
            } 
            else if (goalType == "Checklist Goal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(part[0], part[1], part[2], int.Parse(part[4]), int.Parse(part[3]));
                checklistGoal.CompletedAmount(int.Parse(part[5]));

                _goals.Add(checklistGoal);
            }
        } 
    }
}