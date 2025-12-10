using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating Order 1...");
        Customer c1 = CreateCustomerFromInput();
        Order order1 = new Order(c1);

        for (int i = 0; i < 3; i++)
        {
            order1.AddProduct(CreateProductFromInput());
        }

        Console.WriteLine("\nCreating Order 2...");
        Customer c2 = CreateCustomerFromInput();
        Order order2 = new Order(c2);

        for (int i = 0; i < 3; i++)
        {
            order2.AddProduct(CreateProductFromInput());
        }

        Console.WriteLine("\nORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
        Console.WriteLine(order2.GetShippingLabel());
    }

    static Customer CreateCustomerFromInput()
    {
        Console.Write("Customer name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Address:");
        Console.Write("Street: ");
        string street = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("State/Province: ");
        string state = Console.ReadLine();
        Console.Write("Country: ");
        string country = Console.ReadLine();

        Address address = new Address(street, city, state, country);
        return new Customer(name, address);
    }

    static Product CreateProductFromInput()
    {
        Console.Write("Product name: ");
        string name = Console.ReadLine();

        Console.Write("Product ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Quantity: ");
        int qty = int.Parse(Console.ReadLine());

        return new Product(name, id, price, qty);
    }
}
