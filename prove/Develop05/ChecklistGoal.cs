public class ChecklistGoal : Goal {

    private int _times;
    private int _bonus;
    private int _checkComplete;

    public override int GetTimes() {
        return _times;
    }
    public int GetBonus() {
        return _bonus;
    }
    public override int GetCheckComplete() {
        return _checkComplete;
    }

    public void SetTimes(int times) {
        _times = times;
    }
    public void SetBonus(int bonus) {
        _bonus = bonus;
    }
    public void SetCheckComplete(int complete) {
        _checkComplete = complete;
    }


    public ChecklistGoal() : base() {
        //user input constructor version
        SetType("ChecklistGoal");
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of the goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        SetTimes(int.Parse(Console.ReadLine()));
        Console.Write("What is the bonus for accomplishing it that many times? ");
        SetBonus(int.Parse(Console.ReadLine()));
        SetCheckComplete(0);
        
    }

    public ChecklistGoal(string type, string name, string description, int points, int times, int bonus, int complete)  : base(type, name, description, points) {
        //constructor version for loading in a file
        SetTimes(times);
        SetBonus(bonus);
        SetCheckComplete(complete);
    }

    public override void IsComplete() {
        int comp = GetCheckComplete();
        SetCheckComplete(comp += 1);
        
    }

    public override string GetStringRepresentation() {
        //take the parameters/attributes and make a string out of them
        string type = GetGoalType();
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        int times = GetTimes();
        int bonus = GetBonus();
        int complete = GetCheckComplete();
        return $"{type}:{name}, {description}, {points}, {times}, {bonus}, {complete}";

    }

}