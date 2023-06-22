public class Load {

    public void Loading() {
        List<string> goalList = new List<string>();
        Console.Write("What is the name of the file you would like to load? ");
        string fileName = Console.ReadLine();
        string[] goals = System.IO.File.ReadAllLines(fileName);

        foreach (string myGoal in goals) {
            string[] parts = myGoal.Split(":");
            string parts2 = parts[1];
            if (parts[0] == "SimpleGoal") {
                CreateSimpleGoal(parts2);
            }
            else if (parts[0] == "EternalGoal") {
                CreateEternalGoal(parts2);
            }
            else if (parts[0] == "ChecklistGoal") {
                CreateChecklistGoal(parts2);
            }
        }
         
    }


    public Goal CreateSimpleGoal(string aGoal) { // should just take a string and turn it into a goal, not user input

        string[] parts = aGoal.Split(",");
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        bool complete = bool.Parse(parts[3]);

        Goal simple = new SimpleGoal("SimpleGoal", name, description, points, complete);
        return simple;
        
    }

    public Goal CreateEternalGoal(string aGoal) { 
        string[] parts = aGoal.Split(",");
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);

        Goal eternal = new EternalGoal("EternalGoal", name, description, points);
        return eternal;
        
    }

    public Goal CreateChecklistGoal(string aGoal) { 

        string[] parts = aGoal.Split(",");
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        int times = int.Parse(parts[4]);
        int bonus = int.Parse(parts[5]);
        

        Goal check = new ChecklistGoal("ChecklistGoal", name, description, points, times, bonus);
        return check;
        
    }




}