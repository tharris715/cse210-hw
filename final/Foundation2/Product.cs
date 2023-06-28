public class Poduct {

    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public double Cost() {
        return _price * _quantity;
    }


}