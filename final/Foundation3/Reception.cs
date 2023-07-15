class Reception : Event 
{
    // member variables
    private string _email;

    public Reception(string email, string title, string description, DateTime date, TimeSpan time, Address address, string type) : base(title, description, date, time, address, type)
    {
        _email = email;
    }   
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\n Email: {_email}";
    }
}