public class EternalGoal : Goal {

    public EternalGoal() : base() {
        //user input constructor version
        SetType("EternalGoal");
    }

    public EternalGoal(string type, string name, string description, int points, bool complete) : base(type, name, description, points, complete) {
        //constructor version for loading in a file
        IsComplete();
    }
    public override void IsComplete() {
        SetComplete(false);    
    }

    public override string GetStringRepresentation() {
        //take the parameters/attributes and make a string out of them
        string type = GetGoalType();
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        return $"{type}:{name}, {description}, {points}";

    }

}