public class Outdoor : Event {

    private string _weather;

    public Outdoor(string type, string eventTitle, string description, string date, string time, string address, string weather) : base(type, eventTitle, description, date, time, address){
        _weather = weather;
        _type = type;
    }

    public string OutFullDetails() {
        string fd = $"{_type}, {_eventTitle}, {_description}, {_date}, {_time}, {_address}, {_weather}";
        return fd;
    }


}