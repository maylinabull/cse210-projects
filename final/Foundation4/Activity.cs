class Activity
{
    // member variables
    protected DateTime _date;
    protected int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }
    public virtual double GetDistance()
    {
        return 0.0;
    }
    public virtual double GetSpeed()
    {
        return 0.0;
    }
    public virtual double GetPace()
    {
        return 0.0;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public void SetDate(DateTime date)
    {
        _date = date;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyy")} {GetType().Name} ({GetLength()} min)";
    }
}