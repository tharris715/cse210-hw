public class BreathingActivity : Activity {

    

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration) {
        name = "Breathing Activity";
        description = "Welcome to the Breathing Activity.\n This activity will help you relax by walking you through breathing in and out slowly.\n Clear your mind and focus on your breathing.";
        duration = GetDuration();
        ActiveBreathing(duration);
        DisplayEnd(name, duration);
        
    }


    public void ActiveBreathing(int duration) {
        Console.Clear();
        Console.WriteLine("Get ready...");
        // show the loading circle
        Loading();
        int seconds = duration;

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


}