using System.Linq;
public class Load {

    private int _totalPoints;
    public void SetTotalPoints(int totalPoints) {
        _totalPoints = totalPoints;
    }
    public int GetTotalPoints() {
        return _totalPoints;
    }
    public List<Goal> Loading(string fileName, List<Goal> goalList) {
       
        // read the first line of the file to get the points
        SetTotalPoints(int.Parse(File.ReadLines(fileName).First()));
        // save all the lines from the file to the goals array
        string[] goals = System.IO.File.ReadAllLines(fileName);
        goals = goals.Skip(1).ToArray();
        //split string to get goal type and remaining string
        foreach (string myGoal in goals) {
            string[] parts = myGoal.Split(":");
            string parts2 = parts[1];
            if (parts[0] == "SimpleGoal") {
                goalList.Add(CreateSimpleGoal(parts2));
            }
            else if (parts[0] == "EternalGoal") {
                goalList.Add(CreateEternalGoal(parts2));
            }
            else if (parts[0] == "ChecklistGoal") {
                goalList.Add(CreateChecklistGoal(parts2));
            }
        }
        return goalList;
         
    }

    // Should try to put these into their respective classes with a base method as well
    public Goal CreateSimpleGoal(string aGoal) { 
        // takes a string and turns it into a SimpleGoal, no user input
        string[] parts = aGoal.Split(",");
        string name = parts[0];
        string description = parts[1].TrimStart();
        int points = int.Parse(parts[2]);
        bool complete = bool.Parse(parts[3]);

        Goal simple = new SimpleGoal("SimpleGoal", name, description, points, complete);
        return simple;
    }

    public Goal CreateEternalGoal(string aGoal) { 
        // takes a string and turns it into an EternalGoal, no user input
        string[] parts = aGoal.Split(",");
        string name = parts[0];
        string description = parts[1].TrimStart();
        int points = int.Parse(parts[2]);
        Goal eternal = new EternalGoal("EternalGoal", name, description, points);
        return eternal;
    }

    public Goal CreateChecklistGoal(string aGoal) { 
        // takes a string and turns it into a ChecklistGoal, no user input
        string[] parts = aGoal.Split(",");
        string name = parts[0];
        string description = parts[1].TrimStart();
        int points = int.Parse(parts[2]);
        int times = int.Parse(parts[3]);
        int bonus = int.Parse(parts[4]);
        int complete = int.Parse(parts[5]);
        
        Goal check = new ChecklistGoal("ChecklistGoal", name, description, points, times, bonus, complete);
        return check;
    }

}