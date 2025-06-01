using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("25 Melrose Drive", "Niagara Falls", "ON", "Canada");
        Address address2 = new Address("2106 Colt Drive", "Farmington", "UT", "USA");
        Address address3 = new Address("11582 Skyline Drive", "Highland", "UT", "USA");

        Customer customer1 = new Customer("Freddie Mercury", address1);
        Customer customer2 = new Customer("Alicia Keys", address2);
        Customer customer3 = new Customer("Eddie Vedder", address3);

        Product product1 = new Product("Starburst", "SKU14300", 3.99, 4);
        Product product2 = new Product("Caramello", "SKU76501", 2.59, 5);
        Product product3 = new Product("Pringles", "SKU12098", 1.59, 9);
        Product product4 = new Product("Jerky", "SKU49782", 7.89, 2);
        Product product5 = new Product("Peanuts", "SKU21110", 2.99, 3);

        List<Product> products1 = new List<Product> { product1, product3 };
        List<Product> products2 = new List<Product> { product4, product5 };
        List<Product> products3 = new List<Product> { product2, product3 };

        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);
        Order order3 = new Order(customer3, products3);

        Console.WriteLine("Order #1:");
        order1.GetPackingLabel();
        order1.GetShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.TotalCost():F2}");
        Console.WriteLine($"Shipping Cost: ${order1.GetShippingCost()}");
        Console.WriteLine();

        Console.WriteLine("Order #2:");
        order2.GetPackingLabel();
        order2.GetShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.TotalCost():F2}");
        Console.WriteLine($"Shipping Cost: ${order2.GetShippingCost()}");
        Console.WriteLine();

        Console.WriteLine("Order #3:");
        order3.GetPackingLabel();
        order3.GetShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order3.TotalCost():F2}");
        Console.WriteLine($"Shipping Cost: ${order3.GetShippingCost()}");
        Console.WriteLine();
    }
}