public class Listing : Activity {

    // prompt comes from randomized list
    private string _prompt;
    public Listing(string prompt){
        _prompt = prompt;
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompt} ---");
        Loading();
        Console.ReadLine();

    }


    public void Prompt(){

    }

    public void DisplayPrompt() {

    }


}