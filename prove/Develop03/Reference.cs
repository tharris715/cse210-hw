public class Reference{    
    string _book;    
    int _chapter;    
    int _verse;    
    int _endVerse;    
    public Reference(String book, int chapter, int verse) {        
        _book = book;        
        _chapter = chapter;        
        _verse = verse;    
    }    
        
    public Reference(String book, int chapter, int verse, int endVerse)    {        
        _book = book;        
        _chapter = chapter;        
        _verse = verse;        
        _endVerse = endVerse;    
    }

    public override string ToString() {

        if (_endVerse > 0) {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else {
            return $"{_book} {_chapter}:{_verse}";
        }
 
    }
}