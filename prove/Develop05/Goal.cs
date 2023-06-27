public class Goal{

    private string _type;
    private string _name;
    private string _description;
    private int _points;
    protected int _totalPoints;
    private int _checkComplete;
    


    public Goal() {
          
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

    // public virtual int GetTotalPoints() {
    //     return _totalPoints;
    // }
    public virtual int GetTimes() {
        return 0;
    }
    public virtual int GetCheckComplete() {
        return _checkComplete;
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

    // public void SetTotalPoints(int totalPoints) {
    //     _totalPoints = totalPoints;
    // }
    
    
    
    public virtual void RecordEvent(List<Goal> goals) {
        int choice = 0;
        int points = 0;
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal myGoal in goals) {
            Console.WriteLine($"{count}. {myGoal.GetName()}");
            count += 1;
        }
        Console.Write("Which goal did you accomplish? ");
        choice = int.Parse(Console.ReadLine());
        
        // This next part should call IsComplete and do whatever each class needs to have done
        for (int i = 0; i < goals.Count(); i ++) {
            foreach (Goal myGoal in goals) {
                if (myGoal.GetGoalType() == "SimpleGoal") {
                    myGoal.IsComplete(myGoal);
                    points = myGoal.GetPoints();
                    Load loads = new Load();
                    loads.SetTotalPoints(myGoal.GetPoints());
                }
                else if (myGoal.GetGoalType() == "EternalGoal") {
                    myGoal.IsComplete(myGoal);
                    points = myGoal.GetPoints();
                    Load loads = new Load();
                    loads.SetTotalPoints(myGoal.GetPoints());
                }
                else if (myGoal.GetGoalType() == "ChecklistGoal") {
                    myGoal.IsComplete(myGoal);
                    points = myGoal.GetPoints();
                }
            }

        }
        Console.WriteLine($"Congratulations! You earned {points} points!");
        Load load = new Load();
        load.SetTotalPoints(points);
        Console.WriteLine($"You now have {load.GetTotalPoints()} points.\n");

    }
     // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    public virtual void IsComplete(Goal goal) {
        
    }
    // This method should return true if the goal is completed.




    public virtual string GetStringRepresentation() {
        return "";
    }


    // public virtual Goal CreateGoal() {
    //     Goal goal = new Goal();

    //     return goal;
    // }


}