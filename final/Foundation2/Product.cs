public class Product {
    // Create attributes
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public string GetName() {
        return _name;
    }
    public string GetId() {
        return _id;
    }

    // calculate the cost of a product based on how many customer buys
    public double Cost() {
        return _price * _quantity;
    }

    public Product(string name, string id, double price, int quantity) {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }


}