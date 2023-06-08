public class ReflectionActivity : Activity{

    private string _prompt;
    private string _question;
    private List<string> _questionList = new List<string>() {"What could you learn from this experience that applies to other situations?", "How can you keep this experience in mind in the future?", "What did you learn about yourself through this experience?", "Why was this experience meaningful to you?", "Have you ever done anything like this before?","How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", };
    private List<string> _promptList = new List<string>() {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};


    // input a prompt list and question list, and it will use the random pickers to get the prompt and questions to display
    public ReflectionActivity(string name, string description, int duration, string prompt, string question) : base(name, description, duration) {
        name = "Reflection Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        duration = GetDuration();
           
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {RandomPrompt(_promptList)} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: "); 
        CountDown(5);
        
        
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        Console.Clear();
        // loop through random questions while the duration has not expired
        while (DateTime.Now < end) {
            _question = RandomQuestion(_questionList);
            Console.Write($"> {_question} ");
            Loading();
            Loading();
            Console.WriteLine();
        }

        DisplayEnd(name, duration);
        
        Console.Clear();

    }

    // pick a random prompt
    public string RandomPrompt(List<string> promptList) {
        Random random = new Random();
        int index = random.Next(promptList.Count);
        return promptList[index]; 
    }

    // pick a random question
    public string RandomQuestion(List<string> questionList) {
        Random random = new Random();
        int index = random.Next(questionList.Count);
        
        return questionList[index];
    }

}