public class Running : Activity {

    private int _distance;
    private string _type = "Running";

    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        double speed = Distance()/base._length * 60;
        return speed;
    }
    public override double Pace()
    {
        double pace = base._length / Distance();
        return pace;
    }

    public Running(int length, int distance) : base(length) {
        
    }

}