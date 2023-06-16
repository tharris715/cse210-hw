public class SimpleGoal : Goal {

    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points) {
        type = "Simple Goal";
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of the goal? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());
        
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


    public override SimpleGoal CreateGoal() {
        string type = "Simple Goal";
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        
        SimpleGoal newGoal = new SimpleGoal(type, name, description, points);
        return newGoal;
        
    }


}