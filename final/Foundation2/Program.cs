using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop",1, 800.00,2);
        Product product2 = new Product("Printer", 2, 150.00, 1);
        Customer customer = new Customer("John Doe", new Address("123 Main St", "Cityville", "CA", "USA"));


        Order order1 = new Order(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine($"Total Price: {order1.TotalCostOfOrder():C}");
        Console.WriteLine($"Packing Label:\n{order1.PackingLabel()}");
        Console.WriteLine($"Shipping Label:\n {order1.ShippingLabel()}");
    }
}