using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 USA St.", "USA City", "USA State", "USA");
        Address address2 = new Address("456 This street", "Narvacan", "Ilocos Sur", "Philippines");

        Customer customer1 = new Customer("Therese Gasmen", address1);
        Customer customer2 = new Customer("Pamela Gasmen", address2);

        Product product1 = new Product("Laptop", "G001", 1000, 1);
        Product product2 = new Product("Mouse", "G002", 25, 2);
        Product product3 = new Product("Monitor", "G003", 200, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}