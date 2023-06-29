public class Swimming : Activity {

    private int _laps;
    private string _type = "Swimming";
    

    
    public override double Distance() {
        double distanceKM = _laps * 50 / 1000;

        return distanceKM;
    }
    public override double Speed()
    {
        double speed = Distance() / base._length * 60;
        return speed;
    }
    public override double Pace()
    {
        double pace = base._length / Distance();
        return base.Pace();
    }

    public Swimming(int length, int laps) : base(length) {
        
    }

}