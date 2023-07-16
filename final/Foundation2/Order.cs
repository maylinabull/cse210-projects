using System;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;
        _products = products;

    }
    public double GetTotalCost()
    {
        double total_cost = 0;

        foreach (Product product in _products)
        {
            total_cost += product.GetPrice();
        }
        if (_customer.IsUS())
        {
            total_cost += 5;
        }
        else
        {
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
           packing_label += "\n Product - " + product.GetName() + ", Product ID -  " + product.GetProductId() + "\n";
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