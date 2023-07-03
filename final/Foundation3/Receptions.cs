public class Receptions : Event {

    private string _rsvp;
    

    public Receptions(string type, string eventTitle, string description, string date, string time, string address, string rsvp) : base(type, eventTitle, description, date, time, address){
        _rsvp = rsvp;
        _type = type;
    }

    public string RecFullDetails() {
        string fd = $"{_type}, {_eventTitle}, {_description}, {_date}, {_time}, {_address}, {_rsvp}";
        return fd;
    }

}