public class Event {
    // create shared attributes
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _type;

    // Event constructor, sets all attributes
    public Event(string type, string eventTitle, string description, string date, string time, string address) {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }
    
    //Display standard details
    public string StandardDetails() {
        string sd = $"{_eventTitle}. {_description}, {_date}, {_time}, {_address}.";
        return sd;
    }

    // Display Short Details
    public string ShortDetails() {
        string shortDetail = $"{_type} Event: {_eventTitle}, {_date}";
        return shortDetail;
    }

}