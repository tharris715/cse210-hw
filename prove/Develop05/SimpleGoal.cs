public class SimpleGoal : Goal {

    public SimpleGoal() {   
        
        
        string type = "Simple Goal";
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        
        string simpleString = $"{type}: {name}, {description}, {points}";
        Console.WriteLine(simpleString);
    }

    public override void RecordEvent(int points) {
        // replace the [ ] with [x] and add points to the total
        int total = GetPoints();
        SetPoints(points + total);

    }
    // public override void IsComplete() {
    //     // False until the user records the event, then it is marke with [x] and becomes true
    //     // if user selects the number to go with a simple goal it replaces the [ ] with [x]

    // }


    public override SimpleGoal CreateGoal() { // should just take a string and turn it into a goal, not user input
        string type = "Simple Goal";
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        
        SimpleGoal newGoal = new SimpleGoal();
        return newGoal;
        
    }

    public string GetStringRepresentation(Goal goal) {
        string type = goal.GetGoalType();
        string name = goal.GetName();
        string description = goal.GetDescription();
        int points = goal.GetPoints();
        return $"{type} : {name}, {description}, {points}";

    }



}