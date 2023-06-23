public class ChecklistGoal : Goal {

    private int _times;
    private int _bonus;
    private int _checkComplete;

    public override int GetTimes() {
        return _times;
    }
    public int GetBonus() {
        return _bonus;
    }
    public override int GetCheckComplete() {
        return _checkComplete;
    }

    public void SetTimes(int times) {
        _times = times;
    }
    public void SetBonus(int bonus) {
        _bonus = bonus;
    }
    public void SetCheckComplete(int complete) {
        _checkComplete = complete;
    }


    public ChecklistGoal() {
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
        SetCheckComplete(0);
        
    }

    public ChecklistGoal(string type, string name, string description, int points, int times, int bonus, int complete) {
        SetType(type);
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        SetTimes(times);
        SetBonus(bonus);
        SetCheckComplete(complete);
        
    }

    public override void RecordEvent(List<Goal> goals) {
        int choice = 0;
        int points = 0;
        int times = 0;
        int bonus = 0;
        Console.WriteLine("The goals are:");
        foreach (Goal myGoal in goals) {
            Console.WriteLine(myGoal);
            
        }
        Console.Write("Which goal did you accomplish? ");
        choice = int.Parse(Console.ReadLine());
        int complete = GetCheckComplete();
        for (int i = 0; i < goals.Count(); i ++) {
            foreach (Goal myGoal in goals) {
                if (myGoal.GetGoalType() == "ChecklistGoal") {
                    SetCheckComplete(complete += 1) ;
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
        int times = GetTimes();
        int bonus = GetBonus();
        int complete = GetCheckComplete();
        return $"{type}:{name}, {description}, {points}, {times}, {bonus}, {complete}";

    }

}