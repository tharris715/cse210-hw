public class ChecklistGoal : Goal {

    private int _times;
    private int _bonus;

    public int GetTimes() {
        return _times;
    }
    public int GetBonus() {
        return _bonus;
    }



    public ChecklistGoal(string type, string name, string description, int points, int times, int bonus) {
        _times = times;
        _bonus = bonus;
        type = "ChecklistGoal";
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of the goal? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        times = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        bonus = int.Parse(Console.ReadLine());
        
    }

    public override void RecordEvent(int points) {

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
        return $"{type} : {name}, {description}, {points}";

    }

}