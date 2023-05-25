public class Word {
    private bool _visibility;
    public List<bool> _hideString;
    public Scripture _scripture;

    public string hideStringText;

    public Word(Scripture scripture) {
        _scripture = scripture;
        _hideString = new List<bool>(); // Initialize _hideString list
    }

    // create a list of true, for the length of the scripture

    public void SetList(List<bool> hideList) {
        _hideString = hideList;
    }

    public List<bool> GetList() {
        return _hideString;
    }

    public void GetText() {
        string scriptureText = _scripture.GetScripture();
        string[] myWords = scriptureText.Split(' ');

        for (int i = 0; i < myWords.Length; i++) {
            
            if (myWords[i].Contains("_")) {
                _visibility = false;
            } else {
                _visibility = true;
            }

            _hideString[i] = _visibility;
            SetList(_hideString);
            hideStringText = string.Join(", ", _hideString);
        }
    }

}
