using System.IO;

class Goal 
{
    protected string _type;
    protected string _description;
    protected string _name;
    protected int _points;
    protected bool _status;


    public Goal()
    {

    }
    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    public Goal(string type, string name, string description, int points, bool status)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _status = status;

    }

    // public string GetGoalType()
    // {
    //     return _type;
    // }

    // public string GetDescription()
    // {
    //     return _description;
    // }
    
    // public string GetName()
    // {
    //     return _name;
    // }

    public int GetPoints()
    {
        return _points;
    }
    // public void SetTotalPoints()
    // {
    //     _totalPoints = 0;
    // }
    // public void AddPoints(int points)
    // {
    //     _totalPoints += points;
    // }
    // public int GetTotalPoints()
    // {
    //     return _totalPoints;
    // }

    public virtual string GetSaveFormat() {
        return $"{_type}|{_name}|{_description}|{_points}|{_status}";
    }

    public virtual string GetPrintFormat()
    {
        return " ";
    }


    public virtual void RecordEvent()
    {

    }
    
    public virtual void IsComplete()
    {

    }

    
}