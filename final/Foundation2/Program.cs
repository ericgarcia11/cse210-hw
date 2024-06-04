using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.SetName("milk");
        product1.SetId(1);
        product1.SetQuantity(12);
        product1.SetPrice(2.87);

        Product product2 = new Product();
        product2.SetName("Coke");
        product2.SetId(2);
        product2.SetQuantity(1);
        product2.SetPrice(3.54);
        
        Product product3 = new Product();
        product3.SetName("Whey Protein");
        product3.SetId(3);
        product3.SetQuantity(1);
        product3.SetPrice(83.99);

        Product product4 = new Product();
        product4.SetName("Xis Bomba");
        product4.SetId(4);
        product4.SetQuantity(2);
        product4.SetPrice(69.99);

        Product product5 = new Product();
        product5.SetName("Chocolate de Gramado");
        product5.SetId(5);
        product5.SetQuantity(12);
        product5.SetPrice(34.99);

        Product product6 = new Product();
        product6.SetName("Pizza The Pettit");
        product6.SetId(6);
        product6.SetQuantity(4);
        product6.SetPrice(89.9);


        Address address1 = new Address();
        address1.SetStreet("Rua Archimimo Albino de Abreu 195");
        address1.SetCity("Canela");
        address1.SetState("RS");
        address1.SetCountry("BR");

        Address address2 = new Address();
        address2.SetStreet("Central Perk Street");
        address2.SetCity("New York City");
        address2.SetState("NY");
        address2.SetCountry("US");

        Customer customer1 = new Customer();
        customer1.SetName("Eric Garcia");
        customer1.SetAddress(address1);

        Customer customer2 = new Customer();
        customer2.SetName("Lauren Keller Garcia");
        customer2.SetAddress(address2);

        Order order1 = new Order();
        order1.SetCustomer(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product4);
        order1.AddProduct(product2);
        order1.AddProduct(product6);

        Order order2 = new Order();
        order2.SetCustomer(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product1);


        Console.WriteLine("ORDER 1");
        Console.WriteLine($"SHIPPING LABEL: \n{order1.GetShippingLabel()}"
        + $"\nPACKING LABEL: \n{order1.GetPackingLabel()}"
        + $"\nTOTAL: {order1.TotalPrice()}");

        Console.WriteLine("\n\n   -------------------------   \n\nORDER 2");
        Console.WriteLine($"SHIPPING LABEL: \n{order2.GetShippingLabel()}"
        + $"\nPACKING LABEL: \n{order2.GetPackingLabel()}"
        + $"\nTOTAL: {order2.TotalPrice()}");
    }
}