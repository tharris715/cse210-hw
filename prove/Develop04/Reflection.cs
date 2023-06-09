public class ReflectionActivity : Activity{

    private string _question;
    private List<string> _questionList = new List<string>() {"What could you learn from this experience that applies to other situations?", "How can you keep this experience in mind in the future?", "What did you learn about yourself through this experience?", "Why was this experience meaningful to you?", "Have you ever done anything like this before?","How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", };
    private List<string> _promptList = new List<string>() {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};


    // input a prompt list and question list, and it will use the random pickers to get the prompt and questions to display
    public ReflectionActivity(string name, string description, int duration, string prompt, string question) : base(name, description, duration) {
        duration = GetDuration();    
        ReflectionBody(duration);
        Console.WriteLine();
        DisplayEnd(name, duration);
        Console.Clear();
    }

    private void ReflectionBody(int duration) {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {RandomizeList(_promptList)} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: "); 
        CountDown(5);
        Console.Clear();
        // loop through random questions while the duration has not expired
        DateTime end = Wait(duration);
        while (DateTime.Now < end) {
            _question = RandomizeList(_questionList);
            Console.Write($"> {_question} ");
            Loading();
            Loading();
            Console.WriteLine();
        }
    }
}