public class Goal{

    private string _type;
    private string _name;
    private string _description;
    private int _points;
    private int _checkComplete;

    private bool _complete;
    
    public Goal() {
        //because of the way I load in goals I had to move the shared pieces to the sub classes
        //not sure how to overcome this and add common code back here
    }

    public Goal(string type, string name, string description, int points) {   
        //constructor version for loading in goals
        SetType(type);
        SetName(name);
        SetDescription(description);
        SetPoints(points);
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