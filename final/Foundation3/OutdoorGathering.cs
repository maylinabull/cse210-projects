class OutdoorGathering : Event
{
    // member variables
    private string _weather;

    public OutdoorGathering(string weather, string title, string description, DateTime date, TimeSpan time, Address address, string type) : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\n Weather: {_weather}";
    }
}