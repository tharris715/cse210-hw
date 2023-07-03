public class Event {

    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _type;

    public Event(string type, string eventTitle, string description, string date, string time, string address) {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }
    
    public string GetEventType() {
        return _type;
    }

    public string StandardDetails() {
        string sd = $"{_eventTitle}, {_description}, {_date}, {_time}, {_address}";
        return sd;
    }


    public string ShortDetails() {
        string shortDetail = $"{_type} Event: {_eventTitle}, {_date}";
        return shortDetail;
    }

}