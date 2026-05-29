using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Mesa", "AZ", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "K100", 49.99, 1));
        order1.AddProduct(new Product("Mouse", "M200", 24.99, 2));

        Address address2 = new Address("88 Maple Road", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Emily Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MON300", 199.99, 1));
        order2.AddProduct(new Product("USB Cable", "USB400", 9.99, 3));

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
            Console.WriteLine("----------------------------");
        }
    }
}