using System;

class SimpleGoal : Goal
{
    public SimpleGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points, status)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        _status = true; 
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        Console.WriteLine($"You now have {GetTotalPoints()} points.");
    }
    
    public override void IsComplete()
    {
        _status = true;
    }
    public override string GetSaveFormat() {
        return $"{_type}|{_name}|{_description}|{_points}|{_status}";
    }    
    public override string GetPrintFormat()
    {
        if (_status == true){

            return $"[X] {_name} ({_description})";
        }
        else{
            return $"[ ] {_name} ({_description})";
        }
    }



}