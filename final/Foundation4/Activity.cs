public abstract class Activity {
    // create shared attirbutes
    private DateTime _date = DateTime.Today;
    private int _length;
    private string _type;

    public int GetLength() {
        return _length;
    }

    // create abstract methods to be overridden in each activity subclass
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

    //Display the summary of teh activity outcomes, round values to 2 decimal places
    public void GetSummary() {
        Console.WriteLine($"{_date.ToString("dd MMM yyyy")} {_type} ({_length} min): Distance {Math.Round(Distance(), 2)} km, Speed {Math.Round(Speed(), 2)} kph, Pace: {Math.Round(Pace(), 2)} min per km\n");
    }

    // Activity constructor, set type and length attributes shared by all subclasses
    public Activity(string type, int length) {
        _type = type;
        _length = length;
    }

}