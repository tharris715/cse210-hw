using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("6734 Anza Avenue", "Vista", "CA", "USA");
        Customer customer1 = new Customer("Frank Oz", address1);
        Product product1_1 = new Product("Kermmit Puppet", "ID#34wr61A", 228, 1);
        Product product1_2 = new Product("Yoda Walking Stick", "ID#5TARep5", 113, 3);
        Product product1_3 = new Product("Muppet Themed Blanket", "ID#HBWU7ejsd", 34, 2);
        // create products for order 1
        List<Product> productList1 = new List<Product>();
        productList1.Add(product1_1);
        productList1.Add(product1_2);
        productList1.Add(product1_3);
        // create order1
        Order order1 = new Order(productList1, customer1);

        // Order 2
        Address address2 = new Address("5161 Edloe St", "Hamburg", "GE", "Germany");
        Customer customer2 = new Customer("Peter Clark", address2);
        Product product2_1 = new Product("French Press Coffee", "ID#qwtrg65", 150, 1);
        Product product2_2 = new Product("French Bread", "ID#98hn1ws", 5, 2);
        Product product2_3 = new Product("French Fries (5 lb)", "ID#ndjdo303nid", 15, 4);
        // create products for order 2
        List<Product> productList2 = new List<Product>();
        productList2.Add(product2_1);
        productList2.Add(product2_2);
        productList2.Add(product2_3);
        // create order2
        Order order2 = new Order(productList2, customer2);

        // Display
        Console.Clear();

        Console.WriteLine("Order 1 packing Label:");
        order1.DisplayPackingLabel(productList1);
        Console.WriteLine();
        Console.WriteLine("Order 1 Shipping Label:");
        order1.DisplayShippingLabel();

        Console.WriteLine();

        Console.WriteLine("Order 2 packing Label:");
        order2.DisplayPackingLabel(productList2);
        Console.WriteLine();
        Console.WriteLine("Order 2 Shipping Label:");
        order2.DisplayShippingLabel();


    }
}