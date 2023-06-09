public class ImagineActivity : Activity{

    //private string _scenario;
    private List<string> _scenarioList = new List<string>() {"You are sitting on the beach.", "You are swimming.", "You are in a forest.", "You are on a boat.", "You are seeing your favorite band in concert.", "You are in your favorite travel destination.", "You can see a waterfall.", "You are reading your favorite book.", "You are in a new restaurant.", "You are at a family members celecration.", "You were picked to go on a roundtrip flight to the moon."};


    // input a scenario list and it will use the random pickers to get the scenario
    public ImagineActivity(string name, string description, int duration, string scenario) : base(name, description, duration) {
        duration = GetDuration();
        ImagineBody(duration);
        DisplayEnd(name, duration);
        Console.Clear();
    }

    private void ImagineBody(int duration) {
        Console.WriteLine("Add details (who are with, where are you, what is the weather like, etc.) to the following scenario:\n");
        Console.WriteLine($"--- {RandomizeList(_scenarioList)} ---\n");
        Console.Write("You may begin in: "); 
        CountDown(5);
        Console.WriteLine();
        Thread.Sleep(duration * 1000);
        Console.WriteLine();
        
    }
        
}