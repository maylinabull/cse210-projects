using System;

class Customer
{
    public string _name;
    public Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public Customer()
    {

    }
    public bool IsUS()
    {   
        return _address.IsUS();
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public Address GetFullAddress()
    {
        return _address;
    }
}