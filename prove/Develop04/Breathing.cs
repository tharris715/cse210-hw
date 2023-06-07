public class BreathingActivity : Activity {

    

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration) {
        name = "Breathing Activity";
        description = "Welcome to the Breathing Activity.\n This activity will help you relax by walking you through breathing in and out slowly.\n Clear your mind and focus on your breathing.";
        duration = GetDuration();
        ActiveBreathing(duration);
        DisplayEnd(name, duration);
        Console.Clear();
        
    }


    public void ActiveBreathing(int duration) {
        Console.Clear();
        Console.Write("Get ready...");
        Loading();
        Console.WriteLine();   
        Console.WriteLine();
        int seconds = duration;

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        while (DateTime.Now < end) {
            Console.Write("Breathe in... ");
            CountDown(6);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            CountDown(4);

            Console.WriteLine();
            Console.WriteLine();
        }
        
    }


}