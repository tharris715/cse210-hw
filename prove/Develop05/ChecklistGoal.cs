public class ChecklistGoal : Goal {

    private int _times;
    private int _bonus;

    public int GetTimes() {
        return _times;
    }
    public int GetBonus() {
        return _bonus;
    }

    public void SetTimes(int times) {
        _times = times;
    }
    public void SetBonus(int bonus) {
        _bonus = bonus;
    }



    public ChecklistGoal(string type, string name, string description, int points, int times, int bonus) : base(type, name, description, points){
        SetType("ChecklistGoal");
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of the goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        SetTimes(int.Parse(Console.ReadLine()));
        Console.Write("What is the bonus for accomplishing it that many times? ");
        SetBonus(int.Parse(Console.ReadLine()));
        
    }

    public override void RecordEvent(List<string> goals) {
        int choice = 0;
        int points = 0;
        int times = 0;
        int bonus = 0;
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
        string type = "ChecklistGoal";
        Console.Write("The types of Goals are: \n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal\nWhich type of goal would you like to create?");
        string goalType = Console.ReadLine();
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int times = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());
        ChecklistGoal newGoal = new ChecklistGoal(type, name, description, points, times, bonus);
        return newGoal;

        
    }

    public string GetStringRepresentation(ChecklistGoal goal) {
        string type = goal.GetGoalType();
        string name = goal.GetName();
        string description = goal.GetDescription();
        int points = goal.GetPoints();
        int times = goal.GetTimes();
        int bonus = goal.GetBonus();
        return $"{type}:{name}, {description}, {points}, {times}, {bonus}";

    }

}