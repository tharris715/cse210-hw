public class Activity {

    private int _duration;
    private string _name;
    private string _description; //why is this overriding the setting of these variables in the sub classes?

    public Activity(string name, string description, int duration) {
        Console.Clear();
        name = _name;
        description = _description;
        DisplayStart(name, description); // it is using the name and desc defined above which is empty, how do I get it to use the sub class values?
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get ready...");
        Loading();
        Console.WriteLine();   
        Console.WriteLine();

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

    public void Loading() {
        // This method displays a loading wheel
        List<string> loading = new List<string>();
        loading.Add("|");
        loading.Add("/");
        loading.Add("-");
        loading.Add("\\");
        loading.Add("|");
        loading.Add("/");
        loading.Add("-");
        loading.Add("\\");
        // for every symbol element in the loading list, write the symbol, wait .5 seconds then erase the symbol
        foreach (string symbol in loading) {
            Console.Write(symbol);
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the previous character
        }
    }

    // public void Wait(int seconds) {
    //     seconds = _duration;
    //     DateTime start = DateTime.Now;
    //     DateTime end = start.AddSeconds(seconds);

    //     while (DateTime.Now < end) {
    //         Thread.Sleep(seconds * 100); // does this work??
    //     }
    // }

    public void CountDown(int time) {
        // This method displays a countdown timer that accepts an 
        //int parameter to choose what number to start counting down from
        for (int i = time; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayStart(string name, string description) {
        // Print the start message to the screen using the given name and description parameters
        Console.WriteLine($"Welcome to the {name}");
        Console.WriteLine();
        Console.WriteLine(description);
    }

    public void DisplayEnd(string name, int duration) {
        // Print the end message to the screen using the given name and description parameters
        Console.WriteLine("Well Done!");
        Loading();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the {name}.");
        Loading();
    }

    public void SetStart(string name, string description) {
            _name = name;
            _description = description;         
        }

}