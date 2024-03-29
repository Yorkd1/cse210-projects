public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        IsComplete();
    }

// goal is never completed but still get points after each time
    public override bool IsComplete()
    {
        return false;
    }

// save file format for eternal goals
    public override string GetStringRepresentation()
    {
        string rep = $"Eternal Goal: {_shortName},{_description},{_points}";
        return rep;
    }
}