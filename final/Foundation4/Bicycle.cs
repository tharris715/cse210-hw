public class Bicycle : Activity {

    private int _speed;

    private string _type = "Cycling";

    public override double Distance()
    {
        double distance = Speed()/base._length/60;
        return distance;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        double pace = 60 / Speed();
        return pace;
    }

    public Bicycle(int length, int speed) : base(length) {
        
    }

}