public class SimpleGoal : Goal {

    public SimpleGoal() : base(){   
        //user input constructor version
        SetType("SimpleGoal"); 
        
    }
    public SimpleGoal(string type, string name, string description, int points, bool complete) : base(type, name, description, points, complete) {   

    }   
    
    public override void IsComplete() {
        SetComplete(true);    
    }

    public override string GetStringRepresentation() {
        //take the parameters/attributes and make a string out of them
        string type = GetGoalType();
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        bool complete = GetComplete();
        return $"{type}:{name}, {description}, {points}, {complete}";

    }

}