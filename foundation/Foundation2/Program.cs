using System;

class Program
{
    static void Main(string[] args)
    {
    
        Address address1 = new Address("101 E Viking St", "Rexburg", "ID", "USA");
        Address address2 = new Address("122 E 1230 N St", "Provo", "UT", "USA");

        Customer customer1 = new Customer("Guilherme Melo", address1);
        Customer customer2 = new Customer("Peter Smith", address2);

        Product product1 = new Product("JBL Speaker", "C123", 1200.00, 1);
        Product product2 = new Product("Mouse", "258D", 25.00, 2);

        Product product4 = new Product("Monitor", "D012", 300.00, 2);
        Product product5 = new Product("HD Webcam", "E345", 75.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());
        
    }
}