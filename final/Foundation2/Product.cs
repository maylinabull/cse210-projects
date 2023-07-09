using System;

class Product
{
    private string _name;
    private int _product_id;
    private decimal _price;
    private int _quantity;

    public Product(string name, int product_id, decimal price, int quantity)
    {
        _name = name;
        _product_id = product_id;
        _price = price;
        _quantity = quantity;
    }
    public Product()
    {

    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public int GetProductId()
    {
        return _product_id;
    }
    public void SetProductId(int product_id)
    {
        _product_id = product_id;
    }
    public decimal GetPrice()
    {
        return _price * _quantity;
    }
    public void SetPrice(decimal price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}