using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Apple",113, 0.99m, 2);
        Product product2 = new Product("Diapers",441, 20.95m, 2);
        Product product3 = new Product("Orange Juice", 311, 5.25m, 1);
        Address address1 = new Address("742 Evergreen Terrace" , "Springfield", "Ontario" , "Canada");
        Customer customer1 = new Customer("Velvet Rollin", address1);
        Order order1 = new Order(customer1);

        Product product4 = new Product("Pudding cups",137, 2.35m, 1);
        Product product5 = new Product("Flour",444, 10.93m, 1);
        Product product6 = new Product("Muffins", 333, 5.29m, 2);
        Address address2 = new Address("6884 W Gina Road" , "Herriman", "Utah" , "USA");
        Customer customer2 = new Customer("Deanna Mccall", address2);
        Order order2 = new Order(customer2);

        
        Product product7 = new Product("Milk",12, 1.89m, 2);
        Product product8 = new Product("Lunchable",329, 7.89m, 3);
        Product product9 = new Product("Feastables", 699, 2.35m, 4);
        Address address3 = new Address("1234 Monroe Ave" , "Townsville", "Queensland" , "Australia");
        Customer customer3 = new Customer("Nemo Fischer", address3);
        Order order3 = new Order(customer3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        
        order3.AddProduct(product7);
        order3.AddProduct(product8);
        order3.AddProduct(product9);



        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalCost()}");

        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalCost()}");

        Console.WriteLine(order3.DisplayShippingLabel());
        Console.WriteLine(order3.DisplayPackingLabel());
        Console.WriteLine($"Total: ${order3.GetTotalCost()}");



    }
}