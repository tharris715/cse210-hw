public class EternalGoal : Goal {


    public EternalGoal() {
        SetType("EternalGoal");
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of the goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));        

    }

    public EternalGoal(string type, string name, string description, int points) {
        SetType(type);
        SetName(name);
        SetDescription(description);
        SetPoints(points);        

    }

    public override void RecordEvent(List<Goal> goals) {
        int choice = 0;
        int points = 0;
        Console.WriteLine("The goals are:");
        foreach (Goal myGoal in goals) {
            Console.WriteLine(myGoal);
            
        }
        Console.Write("Which goal did you accomplish? ");
        choice = int.Parse(Console.ReadLine());
        for (int i = 0; i < goals.Count(); i ++) {
            foreach (Goal myGoal in goals) {
                if (myGoal.GetGoalType() == "EternalGoal") {
                    points = myGoal.GetPoints();  
                }
            }
        }
        Console.WriteLine($"Congratulations! You earned {points} points!");
        Load load = new Load();
        load.SetTotalPoints(points);
        Console.WriteLine($"You now have {load.GetTotalPoints()} points.\n");


    }


    public override string GetStringRepresentation() {
        string type = GetGoalType();
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        return $"{type}:{name}, {description}, {points}";

    }




}