public class Breathing : Activity {

    private int _duration;
    private string _startMessage;
    private string _endMessage;

    public Breathing() {
        // use : base to get the duration
        // this is what Activity should display _startMessage = "Welcome to the Breathing Activity.\n This activity will help you relax by walking you through breathing in and out slowly.\n Clear your mind and focus on your breathing.\n How long, in seconds, would you like your session?";      
        _duration = GetDuration();
        _endMessage = $"Well done! \n You have completed another {_duration} seconds of the Breathing Activity.";
    }


    public int GetDuration() {
        return _duration;
    }

    public void SetDuration(int duration) {
        _duration = duration; 
    }

    public void ActiveBreathing(int duration) {
        Console.Clear();
        Console.WriteLine("Get ready...");
        // show the loading circle
        Loading();
        int seconds = _duration;

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        while (DateTime.Now < end) {
            Console.Write("Breathe in... ");
            for (int i = 5; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Breathe out... ");
            for (int i = 5; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        
    }


    public void BreatheIn() {

    }

    public void BreatheOut() {

    }
}