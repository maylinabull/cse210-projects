using System;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> _products, Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();

    }
    public decimal GetTotalCost()
    {
        decimal total_cost = 0;
        foreach (Product product in _products)
        {
            total_cost += product.GetPrice();
        }
        if (_customer.IsUS())
        {
            total_cost += 5;
        }
        else {
            total_cost += 35;
        }
        return total_cost;
    }
    public string GetPackingLabel()
    {
        // name and product id of each product in the order
        string packing_label = " ";
        foreach (Product product in _products)
        {
           packing_label = product.GetName() + product.GetProductId();
        }
        return packing_label;
    }
    public string GetShippingLabel()
    {
        // name and address of the customer 
        return "\n" + _customer.GetName() + "\n" + _customer._address.GetFullAddress();
    }
    public List<Product> Products ()
    {
        return _products;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

}