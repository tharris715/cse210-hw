public class Activity {

    private int _duration;
    private string _name;
    private string _description; //why is this overriding the setting of these variables in the sub classes?

    public Activity(string name, string description, int duration) {
        Console.Clear();
        name = _name;
        description = _description;
        DisplayStart(name, description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

    }

    public int GetDuration(){
        return _duration;
    }

    public string GetName() {
        return _name;
    }

    public string GetDescription() {
        return _description;
    }

    // Animation
    public void Loading() {
        List<string> loading = new List<string>();
        
        loading.Add("|");
        loading.Add("/");
        loading.Add("-");
        loading.Add("\\");
        loading.Add("|");
        loading.Add("/");
        loading.Add("-");
        loading.Add("\\");
        
        foreach (string symbol in loading) {
            Console.Write(symbol);
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the previous character
        }
    }

    public void Wait(int seconds) {
        seconds = _duration;
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        while (DateTime.Now < end) {
            Thread.Sleep(seconds * 100); // does this work??
        }
    }

    public void DisplayStart(string name, string description) {
        Console.WriteLine($"Welcome to the {name}");
        Console.WriteLine();
        Console.WriteLine(description);
    }

    public void DisplayEnd(string name, int duration) {
        Console.WriteLine("Well Done!");
        Loading();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the {name}.");
        Loading();
    }

}