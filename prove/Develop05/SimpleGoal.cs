public class SimpleGoal : Goal {

    private bool _complete = false;
    public bool GetComplete() {
        return _complete;
    }
    
    public void SetComplete(bool complete) {
        _complete = complete;
    }

    public SimpleGoal(string type, string name, string description, int points, bool complete) : base(type, name, description, points){   
        SetType("SimpleGoal");
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of the goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));

    }

    public override void RecordEvent(List<Goal> goals) {
        // new idea is to use a list og goals, use setters or getters where needed, check for is complete? and that will change the display from [ ] to [x]
        // it also needs to record the number of points
        int choice = 0;
        int points = 0;
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal myGoal in goals) {
            Console.WriteLine($"{count}. {myGoal.GetName()}");
            
        }
        Console.Write("Which goal did you accomplish? ");
        choice = int.Parse(Console.ReadLine());
        // how do I access the goal based on the number it was given?

        for (int i = 0; i < goals.Count(); i ++) {
            foreach (Goal myGoal in goals) {
                if (myGoal.GetGoalType() == "SimpleGoal") {
                    SetComplete(true);
                }
            }
        }
        Console.WriteLine($"Congratulations! You earned {points} points!");
        SetTotalPoints(points);
        Console.WriteLine("You know have XX points.");

    }
    
    
    public override Boolean IsComplete(List<string> goals) {
        string comp = "[x]";
        
        foreach (string myGoal in goals) {
            if (myGoal.Contains(comp)) {
                return true;
            }
            else {
                return false;
            }
            
        }
        return false;
    }


    // public override SimpleGoal CreateGoal() { // should just take a string and turn it into a goal, not user input
    //     string type = "Simple Goal";
    //     // get user input to fill in goal parameters
    //     Console.Write("What is the name of your goal? ");
    //     string name = Console.ReadLine();
    //     Console.Write("What is a short description of the goal? ");
    //     string description = Console.ReadLine();
    //     Console.Write("What is the amount of points associated with this goal? ");
    //     int points = int.Parse(Console.ReadLine());
        
    //     SimpleGoal newGoal = new SimpleGoal(type, name, description, points, false);
    //     return newGoal;
        
    // }

    public string GetStringRepresentation() {
        string type = GetGoalType();
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        bool complete = GetComplete();
        return $"{type}:{name}, {description}, {points}, {complete}";

    }



}