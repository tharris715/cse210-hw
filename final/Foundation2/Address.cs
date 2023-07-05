public class Address {
    // create attirbutes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public string GetCountry() {
        return _country;
    }

    public Address(string street, string city, string state, string country) {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // check id address is in the US
    public bool IsUSA() {
        if (GetCountry() == "USA") {
            return true;
        }
        else {
            return false;
        }
    }

    // return the address in string form
    public string GetAddress() {
        string add = $"{_street}\n{_city} {_state}, {_country}";
        return add;
    }

}