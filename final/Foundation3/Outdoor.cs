public class Outdoor : Event {
    // create attributes
    private string _weather;
    // Outdoor constructor, adds weather
    public Outdoor(string type, string eventTitle, string description, string date, string time, string address, string weather) : base(type, eventTitle, description, date, time, address){
        _weather = weather;
    }
    //// Display full details for Outdoor type event
    public string OutFullDetails() {
        string fd = $"{_type} Event: {_eventTitle}. {_description}, {_date}, {_time}, {_address}. Weather forecast is {_weather}.";
        return fd;
    }

}