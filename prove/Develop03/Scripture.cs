public class Scripture{

    private string _scripture = "Adam fell that men might be and men are that they might have joy.";

    Reference head = new Reference("2 Nephi", 2, 25);
    private string _header = "2 Nephi 2:25";


    // Set and get header probably don't need this for the header
    public string GetHeader() {
        return _header;
    }
    public void SetHeader(string head) {
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
        Console.WriteLine($"{_header} {_scripture}");
    }

    public void Hide()
{
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