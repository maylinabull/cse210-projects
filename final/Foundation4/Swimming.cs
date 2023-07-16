class Swimming : Activity
{
    // member variables 
    private double _num_laps;

    public Swimming(DateTime date, int length, double num_laps) : base(date, length)
    {
        _num_laps = num_laps;
    }
    public override double GetDistance()
    {
        return (_num_laps * 50) / 10000;
    }
    public  override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }
    public override double GetPace()
    {
        return _length / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}