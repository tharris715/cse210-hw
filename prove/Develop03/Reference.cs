public class Reference {    
    private string _book;    
    private int _chapter;    
    private int _verse;    
    private int _endVerse;    

    // construct reference for single verse
    public Reference(String book, int chapter, int verse) {        
        _book = book;        
        _chapter = chapter;        
        _verse = verse;    
    }    
    // construct reference for multi verse
    public Reference(String book, int chapter, int verse, int endVerse) {        
        _book = book;        
        _chapter = chapter;        
        _verse = verse;        
        _endVerse = endVerse;    
    }

    // I couldn't get the reference to dsiplay properly so I found a way to override the Reference object back into a string so I could display it more easily
    public override string ToString() {
        if (_endVerse > 0) {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else {
            return $"{_book} {_chapter}:{_verse}";
        }
    }

    // Setters to allow the reference to be changed in the main program
    public void SetReference(String book, int chapter, int verse) {
            _book = book;        
            _chapter = chapter;        
            _verse = verse;          
        }

    public void SetReference(String book, int chapter, int verse, int endVerse) {
            _book = book;        
            _chapter = chapter;        
            _verse = verse;        
            _endVerse = endVerse;   
        }


}