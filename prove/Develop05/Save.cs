public class Save {
           
    public void Saving(List<string> goalList, int totalPoints) {
        Console.Write("What would you like to name the file? ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            outputFile.WriteLine(totalPoints);//start by saving total points
            foreach (string goal in goalList) {
                outputFile.WriteLine($"{goal}");
                
            }
            
            
        }
    }

    // need to save all attributes i.e. is the goal complete or not? as well as the names and types etc
}