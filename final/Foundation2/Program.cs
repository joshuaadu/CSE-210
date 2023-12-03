using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        Address address = new Address("13 South St", "Clayton", "AZ", "USA");
        Customer customer = new Customer("John Doe", address);
        Product product = new Product("Widget", 9.99, 10);
        Order order1 = new Order(customer, new List<Product> { product });
        order1.AddProduct(new Product("Gadget", 4.99, 5));
        order1.AddProduct(new Product("Gizmo", 1.99, 1));

        Console.WriteLine("Order ID: {0}", order1.Id);
        Console.WriteLine("Packing Label: \n{0}", order1.GetPackingLabel());
        Console.WriteLine("Shipping Label: \n{0}", order1.GetShippingLabel());
        Console.WriteLine("Total Price: {0}", order1.GetTotalPrice());
        Console.WriteLine();
        Console.WriteLine();


        Address address2 = new Address("123 Main St", "Anytown", "UT", "USA");
        Customer customer2 = new Customer("John Doe", address2);
        Product product2 = new Product("Widget", 9.99, 10);
        Order order2 = new Order(customer2, new List<Product> { product2 });
        order2.AddProduct(new Product("Gadget", 4.99, 5));
        order2.AddProduct(new Product("Gizmo", 1.99, 1));

        Console.WriteLine("Order ID: {0}", order2.Id);
        Console.WriteLine("Packing Label:\n{0}", order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n{0} ", order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Price: {0}", order2.GetTotalPrice());
        Console.WriteLine();
        Console.WriteLine();


        Address address3 = new Address("1002 Main St", "Anytown", "PA", "FRANCE");
        Customer customer3 = new Customer("John Doe", address3);
        Product product3 = new Product("Widget", 9.99, 10);
        Order order3 = new Order(customer3, new List<Product> { product3 });
        order3.AddProduct(new Product("Gadget", 4.99, 5));
        order3.AddProduct(new Product("Gizmo", 1.99, 1));


        Console.WriteLine("Order ID: {0}", order3.Id);
        Console.WriteLine();
        Console.WriteLine("Packing Label:\n{0}", order3.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n{0} ", order3.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Price: {0}", order3.GetTotalPrice());

    }
}