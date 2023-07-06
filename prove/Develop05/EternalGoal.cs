public class EternalGoal : Goal {
    //user input constructor version
    public EternalGoal() : base() {
        SetType("EternalGoal");
        SetComplete(false);
    }
    //constructor version for loading in a file
    public EternalGoal(string type, string name, string description, int points, bool complete) : base(type, name, description, points, complete) {
    }
    // Goal can never be completed, always set _complete to false
    public override void IsComplete() {
        SetComplete(false);    
    }
}