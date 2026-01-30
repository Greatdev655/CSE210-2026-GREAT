using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ======= Create Addresses =======
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // ======= Create Customers =======
        Customer customer1 = new Customer("Alice Johnson", address1);
        Customer customer2 = new Customer("Bob Smith", address2);

        // ======= Create Products for Order 1 =======
        Product product1 = new Product("Laptop", "L001", 1200.00, 1);
        Product product2 = new Product("Mouse", "M001", 25.50, 2);

        // ======= Create Products for Order 2 =======
        Product product3 = new Product("Monitor", "MN001", 300.00, 1);
        Product product4 = new Product("Keyboard", "K001", 50.00, 1);
        Product product5 = new Product("USB Cable", "U001", 10.00, 3);

        // ======= Create Orders =======
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product3, product4, product5 });

        // ======= Display Order 1 =======
        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice().ToString("0.00"));
        Console.WriteLine();

        // ======= Display Order 2 =======
        Console.WriteLine("=== Order 2 ===");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice().ToString("0.00"));
    }
}
