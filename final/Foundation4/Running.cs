public class Running : Activity {
    // create unique sublass attribute
    private int _distance;
    
    // distance provided as attribute
    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        double speed = Distance()/GetLength() * 60;
        return speed;
    }
    public override double Pace()
    {
        double pace = GetLength() / Distance();
        return pace;
    }

    public Running(string type, int length, int distance) : base(type, length) {
        _distance = distance;
    }

}