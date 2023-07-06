public class ChecklistGoal : Goal {
    //create unique attributes
    private int _times;
    private int _bonus;
    private int _timesComplete;

    // Getters
    public override int GetTimesComplete() {
        return _timesComplete;
    }
    public override int GetTimes() {
        return _times;
    }
    //user input constructor version
    public ChecklistGoal() : base() {
        _type = "ChecklistGoal";
        // get user input to fill in goal parameters
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _times = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
        IsComplete();
    }
    //constructor version for loading in a file
    public ChecklistGoal(string type, string name, string description, int points, bool complete, int times, int bonus, int timesComplete)  : base(type, name, description, points, complete) {
        _times = times;
        _bonus = bonus;
        _timesComplete = timesComplete;
        _complete = complete;
    }
    // handles the bonus points when goal is completed and marks _complete as true
    public override void IsComplete() {
        if (_complete == false) {
            _timesComplete += 1;
            if (_timesComplete == _times) {
                SetComplete(true);
                _points += _bonus;
            }
        }
    }
    // override to include unique stored attributes
    public override string GetStringRepresentation() {
        //take the parameters/attributes and make a string out of them
        return $"{_type}:{_name}, {_description}, {_points}, {_complete}, {_times}, {_bonus}, {_timesComplete}";
    }
}