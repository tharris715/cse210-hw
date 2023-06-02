public class Reflection : Activity{


    private string _prompt;
    private string _question;
    private List<string> _questionList = new List<string>();
    private List<string> _promptList = new List<string>();

    // create list of prompts
    private void PromptList() {
        _promptList.Add("Think of a time when you stood up for someone else.");
        _promptList.Add("Think of a time when you did something really difficult.");
        _promptList.Add("Think of a time when you helped someone in need.");
        _promptList.Add("Think of a time when you did something truly selfless.");   
    }
    //create list of questions
    private void QuestionList() {
        _questionList.Add("Why was this experience meaningful to you?");
        _questionList.Add("Have you ever done anything like this before?");
        _questionList.Add("How did you get started?");
        _questionList.Add("How did you feel when it was complete?");
        _questionList.Add("What made this time different than other times when you were not as successful?");
        _questionList.Add("What is your favorite thing about this experience?");
        _questionList.Add("What could you learn from this experience that applies to other situations?");
        _questionList.Add("What did you learn about yourself through this experience?");
        _questionList.Add("How can you keep this experience in mind in the future?");
    }


    // input a prompt list and question list, and it will use the random pickers to get the prompt and questions to display
    public Reflection(string prompt, string question) {
        _prompt = RandomPrompt(_promptList);
        
        // get more as the user answers previous ones
        _question = RandomQuestion(_questionList);

    }

    // pick a random prompt
    public string RandomPrompt(List<string> promptList) {
        var random = new Random();
        int index = random.Next(promptList.Count);
        return promptList[index];
    }

    // pick a random question
    public string RandomQuestion(List<string> questionList) {
        var random = new Random();
        int index = random.Next(questionList.Count);
        return questionList[index];
    }

}