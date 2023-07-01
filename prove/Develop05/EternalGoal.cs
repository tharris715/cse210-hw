public class EternalGoal : Goal {

    public EternalGoal() : base() {
        //user input constructor version
        SetType("EternalGoal");
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of the goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));        
    }

    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points) {
        //constructor version for loading in a file
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