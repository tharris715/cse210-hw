public class Activity {

    private string _intro = "";
    private string _outro = "";

    public Activity() {
        

    }


    // Set start message for each activity
    public void SetStartMessage(string intro) {
        _intro = intro;
    }

    public string GetStartMessage() {
        return _intro;
    }

    // pause the program for 1 second
    // Thread.Sleep(1000);

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
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        while (DateTime.Now < end) {
            // do something
        }
    }

    public void DisplayStartMesssage() {
        Console.Clear();
        Console.WriteLine(_intro);
    }
    public void DisplayFinishMesssage() {
        Console.WriteLine(_outro);
    }


}