using System;

class Product
{
    private string _name;
    private int _product_id;
    private double _price;
    private int _quantity;

    public Product(string name, int product_id, double price, int quantity)
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
    public double GetPrice()
    {
        return Math.Round((_price * _quantity), 2);
    }
    public void SetPrice(double price)
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