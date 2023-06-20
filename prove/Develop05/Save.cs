public class Save {
           
    public void Saving(List<string> goalList) {
        Console.WriteLine("What would you like to name the file? ");
        string fileName = Console.ReadLine();
            
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            
            foreach (string goal in goalList) {
                outputFile.WriteLine($"{goal}");
            }
            
            outputFile.WriteLine(); // use just like Console.WriteLine() need to add everything in the created list of goals

        }
    }

    // need to save all attributes i.e. is the goal complete or not? as well as the names and types etc
}