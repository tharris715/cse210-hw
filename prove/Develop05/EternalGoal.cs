public class EternalGoal : Goal {


    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points) {
        CreateGoal();

    }

    public override void RecordEvent(int points) {

    }

    public override void IsComplete() {

    }




    public override Goal CreateGoal() {
        string type = "Eternal Goal";
        Console.Write("The types of Goals are: \n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal\nWhich type of goal would you like to create?");
        string goalType = Console.ReadLine();
        // get user input to fill in goal parameters
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());        
        EternalGoal newGoal = new EternalGoal(type, name, description, points);
        return newGoal;
        
    }




}