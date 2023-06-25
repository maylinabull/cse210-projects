using System;
class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        Console.WriteLine($"You now have {GetTotalPoints()} points.");
    }
    
    public override void IsComplete()
    {
        // it's an eternal goal so it's never complete ...
    }
    public override string GetSaveFormat() {
        return $"{_type}|{_name}|{_description}|{_points}";
    }        
    public override string GetPrintFormat()
    {
        return $"[ ] {_name} ({_description})";
        
    }
}