public class SimpleGoal : Goal {

    private bool _complete = false;
    public bool GetComplete() {
        return _complete;
    }
    
    public void SetComplete(bool complete) {
        _complete = complete;
    }

    public SimpleGoal() {   
        SetType("SimpleGoal");
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of the goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));

    }
    public SimpleGoal(string type, string name, string description, int points, bool complete) {   
        SetType(type);
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        SetComplete(complete);

    }


    public override void RecordEvent(List<Goal> goals) {
        // new idea is to use a list of goals, use setters or getters where needed, check for is complete? and that will change the display from [ ] to [x]
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
                    points = myGoal.GetPoints();
                }
            }
        }
        Console.WriteLine($"Congratulations! You earned {points} points!");
        Load load = new Load();
        load.SetTotalPoints(points);
        Console.WriteLine($"You now have {load.GetTotalPoints()} points.\n");

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



    public override string GetStringRepresentation() {
        string type = GetGoalType();
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        bool complete = GetComplete();
        return $"{type}:{name}, {description}, {points}, {complete}";

    }



}