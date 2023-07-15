using System;

class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }
    public Address()
    {
        
    }

    public bool IsUS()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetFullAddress()
    {
        return GetStreetAddress() + "\n"
        + GetCity() + "," + GetState() + " " + GetCountry();
    }
    public string GetStreetAddress()
    {
        return _address;
    }
    public void SetStreetAddress(string address)
    {
        _address = address;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetState()
    {
        return _state;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
}
