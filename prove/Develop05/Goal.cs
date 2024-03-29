using System.Security.Authentication.ExtendedProtection;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    
    public abstract bool IsComplete();
    
// show name and description of goal with it being complete or not
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return($"[x] {_shortName} - {_description}.");
        
        } else 
        {
            return($"[ ] {_shortName} - {_description}.");
        }

    }

// override for saved file representation
    public virtual string GetStringRepresentation()
    {
        string s = $"{_shortName},{_description},{_points}";
        return s;
    }

// change points from string to integer
    public int GetPoints()
    {
        int point = int.Parse(_points);
        return point;
    }
}