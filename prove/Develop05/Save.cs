public class Save {
    // save all attributes of each goal and teh total points
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
}