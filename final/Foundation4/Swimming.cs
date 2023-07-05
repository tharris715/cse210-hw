public class Swimming : Activity {
    // create unique sublass attribute
    private double _laps;
    
    // use laps to get the ditance, then use distance for speed and pace
    public override double Distance() {
        double distance = _laps * 50 / 1000;

        return distance;
    }
    public override double Speed()
    {
        double speed = Distance() / GetLength() * 60;
        return speed;
    }
    public override double Pace()
    {
        double pace = GetLength() / Distance();
        return pace;
    }

    public Swimming(string type, int length, int laps) : base(type, length) {
        _laps = laps;
    }

}