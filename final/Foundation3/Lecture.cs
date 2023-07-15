class Lecture : Event
{
    // member variables
    private int _capacity;
    private string _speaker;

    public Lecture(string speaker, int capacity, string title, string description, DateTime date, TimeSpan time, Address address, string type)
    : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;

    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}, Speaker: {_speaker}, Capacity: {_capacity}";
    }
}