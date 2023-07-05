public class Receptions : Event {
    //create attributes
    private string _rsvp;
    
    // Reception constructor, adds rsvp attribute
    public Receptions(string type, string eventTitle, string description, string date, string time, string address, string rsvp) : base(type, eventTitle, description, date, time, address){
        _rsvp = rsvp;
    }
    // Display full details for Reception type event
    public string RecFullDetails() {
        string fd = $"{_type} Event: {_eventTitle}, {_description}, {_date}, {_time}, {_address}, Please RSVP to {_rsvp}";
        return fd;
    }

}