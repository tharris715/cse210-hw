public class Goal{

    private string _type;
    private string _name;
    private string _description;
    private int _points;
    protected int _totalPoints;


    public Goal(string type, string name, string description, int points) {
          
    }

    public virtual string GetGoalType() {
        return _type;
    } 
    public virtual string GetName() {
        return _name;
    }
    public virtual string GetDescription() {
        return _description;
    }
    public virtual int GetPoints() {
        return _points;
    }

    public virtual int GetTotalPoints() {
        return _totalPoints;
    }
    
    public void SetType(string type) {
        _type = type;
    }

    public void SetName(string name) {
        _name = name;
    }

    public void SetDescription(string description) {
        _description = description;
    }
    
    public void SetPoints(int points) {
        _points = points;
    }

    public void SetTotalPoints(int totalPoints) {
        _totalPoints = totalPoints;
    }
    
    
    public virtual void RecordEvent(List<string> goals) {
        int choice = 0;
        Console.WriteLine("The goals are:");
        //list the goals
        Console.Write("Which goal did you accomplish? ");
        choice = int.Parse(Console.ReadLine());
        //change complete status
        Console.WriteLine("Congratulations! You earned xxxx points!");

    }
     // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    public virtual Boolean IsComplete(List<string> goals) {
        return false;
    }
    // This method should return true if the goal is completed.



    // public int Total(List<string> goals) {
    //     int totalPoints = 0;
    //     foreach (string myGoal in goals) {
    //         string[] parts = myGoal.Replace(":", ",").Split(",");
    //         totalPoints += int.Parse(parts[3]);
            
    //     }
    //     // only count if the goal is complete
    //     return totalPoints;
    // }



    // public string GetStringRepresentation(string type, string name, string description, int points) {
    //     string goalString = $"{type}: {name}, {description}, {points}";
    //     return goalString;

    // }

    // public Goal CreateNewGoal(string goalString) {
    //     List<string> firstSplit = new List<string> (goalString.Split(":"));
    //     string type = firstSplit[0];
    //     List<string> secondSplit = new List<string> (firstSplit[1].Split(","));
    //     string name = secondSplit[0];
    //     string description = secondSplit[1];
    //     int points = int.Parse(secondSplit[2]);
    //     if (secondSplit.Count() > 2) {
    //             int times = int.Parse(secondSplit[3]);
    //             int bonus = int.Parse(secondSplit[4]);
    //         }

    //     return Goal goal = new Goal(type, name, description, points);
        

    // }

    public virtual Goal CreateGoal() {
        Goal goal = new Goal("", "", "", 0);

        return goal;
    }

        


}