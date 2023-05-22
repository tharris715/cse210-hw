public class Scripture{

    public string _scripture = "Adam fell that men might be and men are that they might have joy.";

    private Reference _header = new Reference("2 Nephi", 2, 25);

    // public Scripture() {
    //     string[] verse = _scripture.Split(' ');
    //     List<string> words = verse.ToList();
    //     foreach (string word in words) {
    //         Word aWord = new Word(word);
    //         // call methods to hide or show the word

    //     }

    // }

    // Set and get header
    public Reference GetHeader() {
        return _header;
    }
    public void SetHeader(Reference head) {
        _header = head;
    }

    // Set and get scripture
    public string GetScripture() {
        return _scripture;
    }
    public void SetScripture(string scripture) {
        _scripture = scripture;
    }

    public void Display() {
        // add section to display the hidden version of the scripture
        string headString = _header.ToString();
        Console.WriteLine($"{headString} {_scripture}");
    }

public void Hide() {
    string[] verse = _scripture.Split(' ');
    Random random = new Random();

    for (int i = 0; i < 3; i++)
    {
        int index = random.Next(verse.Length);
        verse[index] = new string('_', verse[index].Length);
         
    }

    string replacedString = string.Join(" ", verse);
    SetScripture(replacedString);
    Console.Clear();
    Display();
    }
    

}