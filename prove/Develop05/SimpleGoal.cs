public class SimpleGoal : Goal {
    //user input constructor version
    public SimpleGoal() : base() {   
        SetType("SimpleGoal"); 
        SetComplete(false);
    }
    //constructor version for loading in a file
    public SimpleGoal(string type, string name, string description, int points, bool complete) : base(type, name, description, points, complete) {   
    }   
    // set _complete to true when goal is recorded
    public override void IsComplete() {
        if (_complete != true) {
            SetComplete(true);    
        }
    }
}