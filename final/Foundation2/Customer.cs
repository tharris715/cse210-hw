public class Customer {
    // create attributes
    private string _name;
    private Address _address;

    // Get the status of the US address and return boolean
    public bool GetUSA() {
        return _address.IsUSA();
    }

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public string GetCustomer() {
        return _name;
    }
    // Get address using customer class
    public string GetAddress2() {
        return _address.GetAddress();
    }


}