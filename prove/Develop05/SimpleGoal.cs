public class SimpleGoal : Goal {

    private bool _complete = false;

    public SimpleGoal() : base(){   
        //user input constructor version
        SetType("SimpleGoal"); 
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of the goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));
    }
    public SimpleGoal(string type, string name, string description, int points, bool complete) : base(type, name, description, points) {   
        //constructor version for loading in a file
        SetComplete(complete);
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