public class Lectures : Event {

    private string _speaker;
    private int _capacity;
    

    public Lectures(string type, string eventTitle, string description, string date, string time, string address, string speaker, int capacity) : base(type, eventTitle, description, date, time, address){
        _speaker = speaker;
        _capacity = capacity;
        _type = type;
    }

    public string LecFullDetails() {
        string fd = $"{_type}, {_eventTitle}, {_description}, {_date}, {_time}, {_address}, {_speaker}, {_capacity}";
        return fd;
    }


}