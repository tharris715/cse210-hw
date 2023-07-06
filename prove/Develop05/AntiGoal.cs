public class AntiGoal : Goal {
    //create unique attributes
    private int _timesDone;
    private int _escalation;

    //user input constructor version
    public AntiGoal() : base() {
        SetType("AntiGoal");
        SetComplete(false);
        Console.Write("Set amount of points to escalate each time. ");
        _escalation = int.Parse(Console.ReadLine());
        _points *= -1;
        _timesDone = 0;
    }
    //constructor version for loading in a file
    public AntiGoal(string type, string name, string description, int points, bool complete, int escalation, int timesDone) : base(type, name, description, points, complete) {
        _escalation = escalation;
        _timesDone = timesDone;
    }
    // handles the point escalation, no option for goal being completed
    public override void IsComplete() {
        SetComplete(false);
        int esc = 0;
        if (_timesDone == 0) {
            _points -= esc;
        }
        else if (_timesDone > 0) {
            esc += _escalation;
            _points -= esc;
        }
        _timesDone += 1;    
    }
    // override to include unique stored attributes
    public override string GetStringRepresentation() {
        //take the parameters/attributes and make a string out of them
        return $"{_type}:{_name}, {_description}, {_points}, {_complete}, {_escalation}, {_timesDone}";
    }

}