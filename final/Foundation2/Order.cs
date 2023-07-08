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
        Customer customer = new Customer();
        foreach (Product product in _products)
        {
            total_cost += product.GetPrice();
        }
        if (customer.IsUS())
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
        Product product = new Product();
        return product.GetName() + " " + product.GetProductId();
    }
    public string GetShippingLabel()
    {
        // name and address of the customer 
        Customer customer = new Customer();
        return customer.GetName() + " " + customer.GetFullAddress();
    }
    public List<Product> Products ()
    {
        return _products;
    }

}