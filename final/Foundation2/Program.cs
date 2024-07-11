using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "LTP1001", 999.99, 2);
        Product product2 = new Product("Mouse", "MSE2002", 49.99, 1);
        Product product3 = new Product("Desk Pad", "DP3003", 19.99, 1);

        Product product4 = new Product("Monitor", "MNT4004", 299.99, 1);
        Product product5 = new Product("Webcam", "WBC5005", 79.99, 2);
        Product product6 = new Product("Headset", "HST6006", 129.99, 1);


        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "London", "Greater London", "UK");


        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);


        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        List<Order> orders = new List<Order> { order1, order2 };


        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}