public class ChecklistGoal : Goal {

    private int _times;
    private int _bonus;
    private int _timesComplete;

    public override int GetTimes() {
        return _times;
    }
    public int GetBonus() {
        return _bonus;
    }
    public int GetTimesComplete() {
        return _timesComplete;
    }

    public void SetTimes(int times) {
        _times = times;
    }
    public void SetBonus(int bonus) {
        _bonus = bonus;
    }
    public void SetTimesComplete(int complete) {
        _timesComplete = complete;
    }


    public ChecklistGoal() : base() {
        //user input constructor version
        _type = "ChecklistGoal";
        // get user input to fill in goal parameters
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _times = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
        
    }

    public ChecklistGoal(string type, string name, string description, int points, bool complete, int times, int bonus, int timesComplete)  : base(type, name, description, points, complete) {
        //constructor version for loading in a file
        _times = times;
        _bonus = bonus;
        _timesComplete = timesComplete;
        _complete = false;
    }

    public override void IsComplete() {
        int comp = GetTimesComplete();
        _timesComplete = comp + 1;
    }

    public override string GetStringRepresentation() {
        //take the parameters/attributes and make a string out of them
        string type = GetGoalType();
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        int times = GetTimes();
        int bonus = GetBonus();
        int timesComplete = _timesComplete;
        return $"{type}:{name}, {description}, {points}, {times}, {bonus}, {timesComplete}";

    }

}