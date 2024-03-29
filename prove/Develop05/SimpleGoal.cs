public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

// save file format for simple goals
    public override string GetStringRepresentation()
    {
        string rep = $"Simple Goal:{_shortName},{_description},{_points},{_isComplete}";
        return rep;
    }
}