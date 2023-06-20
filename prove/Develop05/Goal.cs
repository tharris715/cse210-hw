public class Goal{

    private string _type;
    private string _name;
    private string _description;
    private int _points;


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

    
    
    public virtual void RecordEvent(int points) {

    }
     // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    public void IsComplete() {

    }
    // This method should return true if the goal is completed.









    
    
    public void Save() {
        Console.WriteLine("What would you like to name the file? ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
        
        outputFile.WriteLine(); // use just like Console.WriteLine() need to add everything in the created list of goals

        }
    }

    public void Load(string filename) {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines) {
            string[] parts = line.Split(",");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            if (line.Count() > 3) {
                string times = parts[4];
                string bonus = parts[5];
            }

        }


    }

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
        Goal goal = new Goal();

        return goal;
    }

        


}