class Running : Activity
{
    // member variables 
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public  override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }
    public override double GetPace()
    {
        return  _length / _distance;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}