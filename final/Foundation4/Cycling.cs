class Cycling : Activity
{
    // member variables
    private double _speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed / 60 * _length;
    }
    public  override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return _length / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {_speed} mph, Pace: {GetPace()} min per mile";
    }
}