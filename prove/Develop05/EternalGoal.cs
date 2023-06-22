public class EternalGoal : Goal {


    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points) {
        SetType("EternalGoal");
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of the goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));        

    }

    public override void RecordEvent(List<string> goals) {
        int choice = 0;
        int points = 0;
        Console.WriteLine("The goals are:");
        foreach (string myGoal in goals) {
            Console.WriteLine(myGoal);
            
        }
        Console.Write("Which goal did you accomplish? ");
        choice = int.Parse(Console.ReadLine());
        for (int i = 0; i < goals.Count(); i ++) {
            foreach (string myGoal in goals) {
                if (choice == myGoal[0]) {
                    string[] parts = myGoal.Replace(":", ",").Split(",");
                    points = int.Parse(parts[3]);  
                }
            }
        }
        Console.WriteLine($"Congratulations! You earned {points} points!");


    }

    // public override void IsComplete() {

    // }




    public override Goal CreateGoal() {
        string type = "Eternal Goal";
        Console.Write("The types of Goals are: \n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal\nWhich type of goal would you like to create?");
        string goalType = Console.ReadLine();
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());        
        EternalGoal newGoal = new EternalGoal(type, name, description, points);
        return newGoal;
        
    }

    public string GetStringRepresentation(Goal goal) {
        string type = goal.GetGoalType();
        string name = goal.GetName();
        string description = goal.GetDescription();
        int points = goal.GetPoints();
        return $"{type}:{name}, {description}, {points}";

    }




}