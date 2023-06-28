public class Address {

    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public string USA() {
        if (_country == "USA") {
            return "Address is in USA";
        }
        else {
            return "Address is not in the USA";
        }
    }

}