using System;

class Program
{
    static void Main(string[] args)
    {
        // create new order 1
        Address address1 = new Address("111 Tree Ave.", "Kansas City", "MO", "USA");
        Customer customer1 = new Customer("Robert Williams", address1);
        List<Product> customers_products1 = new List<Product>();
        Product product1 = new Product("Pencils", 1, 2.25m, 1);
        Product product2 = new Product("Erasers", 2, .25m, 2);
        customers_products1.Add(product1);
        customers_products1.Add(product2);
        Order order1 = new Order(customers_products1, customer1);

        // create new order 2
        Address address2 = new Address("222 Flower St.", "Tokyo", "Tokyo-to", "Japan");
        Customer customer2 = new Customer("Anya Forger", address2);
        List<Product> customers_products2 = new List<Product>();
        Product product3 = new Product("Coloring book", 3, 2.00m, 3);
        Product product4 = new Product("Peanuts", 4, 50.00m, 50);
        Product product5 = new Product("Headband", 5, 3.25m, 1);
        customers_products2.Add(product3);
        customers_products2.Add(product4);
        customers_products2.Add(product5);
        Order order2 = new Order(customers_products2, customer2);

        // get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
        Console.WriteLine("Order #1: ");
        Console.WriteLine($"Total Cost: {order1.GetTotalCost()}");
        Console.WriteLine($"Packing Label: {order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {order1.GetShippingLabel()}");
        Console.WriteLine("");

        Console.WriteLine("Order #2: ");
        Console.WriteLine($"Total Cost: {order2.GetTotalCost()}");
        Console.WriteLine($"Packing Label: {order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {order2.GetShippingLabel()}");
        Console.WriteLine("");
    }
}