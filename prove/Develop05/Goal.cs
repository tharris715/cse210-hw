public class Goal{

    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _complete;
    protected int _timesComplete;


    public Goal(string type, string name, string description, int points, bool complete) {   
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
    } 
    
    public Goal() {
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of the goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));
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

    public virtual bool GetComplete() {
        return _complete;
    }
    public virtual int GetTimes() {
        return 0;
    }
    public virtual int GetTimesComplete() {
        return _timesComplete;
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

    public void SetComplete(bool complete) {
        _complete = complete;
    }

     // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    public virtual void IsComplete() {
        
    }
  

    public virtual string GetStringRepresentation() {
        //take the parameters/attributes and make a string out of them
        return "";
    }


}