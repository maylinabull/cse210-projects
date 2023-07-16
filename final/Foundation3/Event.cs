class Event
{
    // member variables
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;
    private string _type;


    public Event(string title, string description, DateTime date, TimeSpan time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\n Description: {_description}\n Date: {_date.ToString("MM/dd/yyy")}\n Time: {_time}\n Address: {_address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return $"Type: {_type}\n{GetStandardDetails()}";
    }
    public string GetShortDescription()
    {
        return $"Type: {_type}\n Title: {_title}\n Date: {_date.ToString("MM/dd/yyy")}";
    }
}