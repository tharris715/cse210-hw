public class Word {
    public List<bool> _hideString;
    private Scripture _scripture;

    private string hideStringText;

    public Word(Scripture scripture) {
        _scripture = scripture;
        _hideString = new List<bool>(); // Initialize _hideString list
    }

    // create a list of true, for the length of the scripture

    private void SetList(List<bool> hideList) {
        _hideString = hideList;
    }



    public void GetText() {
        string scriptureText = _scripture.GetScripture();
        string[] myWords = scriptureText.Split(' ');

        _hideString.Clear();

        foreach (var word in myWords) {
            bool visibility = !word.Contains("_");
            _hideString.Add(visibility);
        }

        hideStringText = string.Join(", ", _hideString);
    }
    

}
