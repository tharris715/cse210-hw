public class Activity {

    private DateTime _date;
    protected int _length;
    private string _type = "";
    
    protected void SetDate() {
        _date = DateTime.Today;
    }

    public virtual double Distance() {
        return 0;
    }

    public virtual double Speed() {
        return 0;
    }
    public virtual double Pace() {
        return 0;
    }

    public void GetSummary() {
        Console.WriteLine($"{_date} {_type} ({_length}): Distance {Distance()} km, Speed {Speed()} kph, Pace {Pace} min per km");
    }

    public Activity(int length) {

    }

}