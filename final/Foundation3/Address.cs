public class Address {
    // create attirbutes
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    public Address(string street, string city, string state, string country) {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // return the address in string form
    public string GetAddress() {
        string add = $"Location: {_street}, {_city} {_state}, {_country}";
        return add;
    }

}
