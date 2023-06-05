public class ListingActivity : Activity {

    // prompt comes from randomized list
    private string _prompt;

    public ListingActivity(string name, string description, int duration, string prompt) : base(name, description, duration){
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
        _prompt = prompt;
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompt} ---");
        Loading();
        Console.ReadLine();

    }

    public string GetPrompt() {
        return _prompt;
    }


    public void Prompt(){

    }

    public void DisplayPrompt() {

    }


}