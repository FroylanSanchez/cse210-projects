using System;

namespace Foundation2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Customer c1 = new Customer(
                "Froylan Sanchez",
                new Address("140 W 2nd S", "Rexburg", "ID", "USA")
            );

            Order order1 = new Order(c1);
            order1.AddProduct(new Product("Phone", 1231, 1000, 1));
            order1.AddProduct(new Product("Headphones", 242, 1313, 2));
            order1.AddProduct(new Product("Charger", 23, 11, 1));

            Customer c2 = new Customer(
                "Luz Sanchez",
                new Address("Av. Central 45", "Ecatepec de Morelos", "Mexico", "Mexico")
            );

            Order order2 = new Order(c2);
            order2.AddProduct(new Product("Notebook", 1, 5, 4));
            order2.AddProduct(new Product("Pen Pack", 2, 3, 2));
            order2.AddProduct(new Product("Backpack", 4, 25, 1));

            Console.WriteLine("ORDER 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
            Console.WriteLine(order1.GetShippingLabel());

            Console.WriteLine("\nORDER 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
            Console.WriteLine(order2.GetShippingLabel());
        }
    }
}
