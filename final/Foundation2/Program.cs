using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new Product("Laptop", 1, 800.00, 2);
        Product product2 = new Product("Headphones", 2, 50.00, 3);
        Product product3 = new Product("Mouse", 3, 20.00, 5);

        // Create addresses
        Address usaAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Address nonUsaAddress = new Address("161 Umjelo Cresent", "Vosloorus", "Johannesburg", "South Africa");

        // Create customers
        Customer customer1 = new Customer("Paul Waker", usaAddress);
        Customer customer2 = new Customer("Thabang Mothata", nonUsaAddress);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display results
        Console.WriteLine("Order 1 - Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 - Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 - Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("Order 2 - Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 - Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 - Total Price: $" + order2.GetTotalPrice());
    }
}








