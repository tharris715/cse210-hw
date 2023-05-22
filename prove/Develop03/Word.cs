public class Word {

    // a class to represent individual words. Check if all words were replaced with _, if so end the program
    // Get the verse as it is on the screen

    public string GetText()
    {
        // Create an instance of the Scripture class
        Scripture scripture = new Scripture();

        // Call the GetScripture method to retrieve the scripture string
        string scriptureText = scripture.GetScripture();

        // Use the scripture string as needed
        return scriptureText;
    }

    string verse GetText();
    Random random = new Random();

    for (int i = 0; i < 3; i++)
    {
        int index = random.Next(verse.Length);
        verse[index] = new string('_', verse[index].Length);
        // take each word and determine if it is _ or leters
        // if _ in word count += 1
        // if count = verse.Length end the
    }

    // public Word(string word) {
    //     string[] verseA = verse._scripture;
    //     List<string> words = verse.ToList();
    //     foreach (string word in words) {
    //         Word aWord = new Word(word);
    //     }
    // }




    public void Hidden() {

    }

    public void GetText(string verse) {
        return verse;
    }

}