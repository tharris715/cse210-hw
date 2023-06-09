public class BreathingActivity : Activity {

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration) {
        duration = GetDuration();
        BreathingBody(duration);
        DisplayEnd(name, duration);
        Console.Clear();  
    }

    private void BreathingBody(int duration) {
        // This is the core of the breathing activity. It prints the messages, 
        // handles the time for breathing in and out, and limits the activity 
        // to the user selected duration
        
        DateTime end = Wait(duration);

        while (DateTime.Now < end) {
            Console.Write("Breathe in... ");
            CountDown(6);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            CountDown(4);

            Console.WriteLine("\n");
        }        
    }
}