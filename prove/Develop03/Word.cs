public class Word {

 // a class to represent individula words. Put them into an array and then have each word be an index
    
    Scripture verse = new Scripture();

// read in all the words as an array
//track if they are hidden
    private string _word;

    public Word(string word) {
        string[] verseA = verse._scripture;
        List<string> words = verse.ToList();
        foreach (string word in words) {
            Word aWord = new Word(word);
        }
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











    public void Hidden() {

    }

    public void GetText() {
        // gets the scripture as it is such as with words hidden
    }

}