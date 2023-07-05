public class Lectures : Event {
    // create attributes
    private string _speaker;
    private int _capacity;
    
    // Lecture constructor, adds speaker and capacity
    public Lectures(string type, string eventTitle, string description, string date, string time, string address, string speaker, int capacity) : base(type, eventTitle, description, date, time, address){
        _speaker = speaker;
        _capacity = capacity;
    }
    // Display full details for lecture type event
    public string LecFullDetails() {
        string fd = $"{_type} Event: {_eventTitle}, {_description}, {_date}, {_time}, {_address}, Speaker: {_speaker}, Capacity: {_capacity}";
        return fd;
    }


}