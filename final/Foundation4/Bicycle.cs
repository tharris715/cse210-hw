public class Bicycle : Activity {
    // create unique sublass attribute
    private int _speed;

    public override double Distance()
    {
        double distance = GetLength()/Speed()*60;
        return distance;
    }
    // speed provided as attribute
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        double pace = 60 / Speed();
        return pace;
    }

    public Bicycle(string type, int length, int speed) : base(type, length) {
        _speed = speed;
    }

}