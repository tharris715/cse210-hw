public class ListingActivity : Activity {

    // prompt comes from randomized list
    private string _prompt;
    private List<string> _promptList = new List<string>() {"Who are some of your personal heroes?","When have you felt the Holy Ghost this month?","Who are people that you have helped this week?","What are personal strengths of yours?","Who are people that you appreciate?"};


    public ListingActivity(string name, string description, int duration, string prompt) : base(name, description, duration){
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        duration = GetDuration();
        prompt = RandomPrompt(_promptList);
        
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();

        int count = 0;
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        while (DateTime.Now < end) {
            Console.Write("> ");
            Console.ReadLine();
            count += 1;
        }
        Console.WriteLine($"You entered {count} responses!");
        Loading();
        Console.WriteLine();
        DisplayEnd(name, duration);

        Console.Clear();
    }

    private string GetPrompt() {
        return _prompt;
    }


    private string RandomPrompt(List<string> promptList) {
        var random = new Random();
        int index = random.Next(promptList.Count);
        return promptList[index];
    }


}