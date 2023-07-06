public abstract class Goal{
    // create attributes
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _complete = false;
    protected int _timesComplete;


    public Goal(string type, string name, string description, int points, bool complete) {   
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
    } 
    
    public Goal() {
        // get user input to fill in goal parameters, inherited by all subclasses
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of the goal? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    // Getters and Setters
    public string GetGoalType() {
        return _type;
    } 
    public string GetName() {
        return _name;
    }
    public string GetDescription() {
        return _description;
    }
    public int GetPoints() {
        return _points;
    }

    public bool GetComplete() {
        return _complete;
    }
    public virtual int GetTimes() {
        return 0;
    }
    public virtual int GetTimesComplete() {
        return _timesComplete;
    }
    
    protected void SetType(string type) {
        _type = type;
    }

    protected void SetComplete(bool complete) {
        _complete = complete;
    }

     // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    public abstract void IsComplete();
  
    // base version, can be overriden where needed (AntiGoal and ChecklistGoal)
    public virtual string GetStringRepresentation() {
        //take the parameters/attributes and make a string out of them
        return $"{_type}:{_name}, {_description}, {_points}, {_complete}";
    }

}