using System;
class ChecklistGoal : Goal
{
    private int _bonus;
    private int _numTimes;
    private int _count;

    // 1st time goal is completed, GetPoints just returns _points. increment count so now its 1
    // 2nd time goal is completed, GetPoints just returns _points increment count so now its 2
    // 3rd time goal is completed, GetPoints returns _points + bonus because count is 3, and so it _numTimes.
    // we also set status to true. 


    public ChecklistGoal(string type, string name, string description, int points, int numTimes, int count, int bonus, bool status) : base(type, name, description, points, status)
    {
        _type = type;
        _status = false;
        _numTimes = numTimes;
        _count = count;
        _bonus = bonus;
        _points = points;
    }
    public ChecklistGoal(string type, string name, string description, int points, int numTimes, int bonus) : base(type, name, description, points)
    {
        _numTimes = numTimes;
        _bonus = bonus;
        _points = points;
    }

    public override string GetSaveFormat()
    {
        return $"{base.GetSaveFormat()}|{_count}/{_numTimes}|{_bonus} bonus points for completion";
    }

    // if user completes checklist goal add bonus
    // public int GetBonusPoints()
    // {
            // return _bonus;
    // }
    public void SetNumTimes()
    {

    }
    // public int GetNumTimes()
    // {
            // return _numTimes;
    // } 

    public override void RecordEvent()
    {
        _points = GetPoints();

        if (_count == _numTimes)
        {
            _status = true;
            _points += _bonus; 
            
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
         _count ++;
        // Console.WriteLine($"You now have {GetTotalPoints()} points.");
    }
    
    public override void IsComplete()
    {
        // complete if user completes the goal a certain amount of times
        if (_count ==_numTimes)
        {
             _status = true;
        }
        else
        {
            _count += 1;
        }
    }

        public override string GetPrintFormat()
    {
        if (_status == true ||_count == _numTimes)
        {

            return $"[X] {_name} ({_description}) -- Currently complete {_count}/{_numTimes}";
        }
        else{
            return $"[ ] {_name} ({_description}) -- {_count}/{_numTimes}";
        }
    }
}