public class Load {

    public void Loading() {
        Console.WriteLine("What is the name of the file you would like to load? ");
        string fileName = Console.ReadLine();
        string[] goals = File.ReadAllLines(fileName);

        foreach (string myGoal in goals) {
            CreateGoal(myGoal);
        }
        
    }


    public Goal CreateGoal(string aGoal) { // should just take a string and turn it into a goal, not user input
               
        Goal newGoal = new Goal();

        newGoal.SetType(aGoal[0].ToString());
        newGoal.SetName(aGoal[1].ToString());
        newGoal.SetDescription(aGoal[2].ToString());
        newGoal.SetPoints(aGoal[3]);

        return newGoal;
        
    }




}