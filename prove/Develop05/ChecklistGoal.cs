public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

// user completion of checklist goal
    public override void RecordEvent()
    {
        _amountCompleted += 1;

        if (_target == _amountCompleted)
        {
            int total = int.Parse(_points) + _bonus;
            SetPoints(total);
        }
    }

// if completed the amount of times then goal is complete
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

// override method for showing details of checklist goal
    public override string GetDetailsString()
    {
        return ($"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}");
    }

// override method for saving checklist goal format to file
    public override string GetStringRepresentation()
    {
        string rep = $"Checklist Goal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
        return rep;
    }

    public void CompletedAmount(int amount)
    {
        _amountCompleted = amount;
    }

// change integer points to string points
    public void SetPoints(int points)
   {
    _points = points.ToString();
   } 
}