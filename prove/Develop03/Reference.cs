public class Reference{    
    string _book;    
    int _chapter;    
    int _verse;    
    int _endVerse;    
    Reference(String book, int chapter, int verse) {        
        _book = book;        
        _chapter = chapter;        
        _verse = verse;    
    }    
        
    Reference(String book, int chapter, int verse, int endVerse)    {        
        _book = book;        
        _chapter = chapter;        
        _verse = verse;        
        _endVerse = endVerse;    
    }
}