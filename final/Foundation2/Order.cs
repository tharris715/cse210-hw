public class Order {
    // Create attibutes
    private List<Product> _products;
    private Customer _customer;
    
    //Show the packing label on the console as well as the total cost, 
    //requires a list of products, customer address
    public void DisplayPackingLabel(List<Product> products) {
        foreach (Product product in products) {
            Console.WriteLine($"{product.GetName()}, {product.GetId()}");
        }
    }
    // print the shipping label to the console
    // require customer information and address as a string
    public void DisplayShippingLabel() {
        Console.WriteLine($"{_customer.GetCustomer()}");
        Console.WriteLine($"{_customer.GetAddress2()}");
    }

    public void TotalCost(List<Product> products) {
        double total = 0;
        foreach (Product product in products) {
            double cost = product.Cost();
            total += cost;
        }
        if (_customer.GetUSA() == true) {
            total += 5;
        }
        else {
            total += 35;
        }
        
        Console.WriteLine($"Total cost: ${total}");
    }

    public Order(List<Product> products, Customer customer) {
        _products = products;
        _customer = customer;
    }

}