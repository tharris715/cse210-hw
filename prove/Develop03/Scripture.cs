public class Scripture{

    private string _scripture = "Adam fell that men might be and men are that they might have joy.";

    private Reference _header;

    public Scripture(Reference reference) {
        _header = reference;
        _scripture = GetScripture();
    }


    // Set and get scripture
    public string GetScripture() {
        return _scripture;
    }
    public void SetScripture(string scripture) {
        _scripture = scripture;
    }

    public void Display() {
        // Display the scripture and the reference
        string headString = _header.ToString();
        Console.WriteLine($"{headString} {_scripture}");
    }

public void Hide() {
    // split the scripture into individual words
    string[] verse = _scripture.Split(' ');
    Random random = new Random();

    // loop through the scripture 3 times to remove a word each time
    for (int i = 0; i < 3; i++) {
        int index = random.Next(verse.Length);
        verse[index] = new string('_', verse[index].Length); 
    }
    // Join the string back together again
    string replacedString = string.Join(" ", verse);
    SetScripture(replacedString);
    Console.Clear();
    Display();
    }
    


}