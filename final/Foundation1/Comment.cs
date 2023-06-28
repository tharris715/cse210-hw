public class Comment {

    private string _name;
    private string _text;

    public void SetName(string name) {
        _name = name;
    }

    public void SetText(string text) {
        _text = text;
    }

    public string GetName() {
        return _name;
    }

    public string GetText() {
        return _text;
    }


//A comment should be defined by the Comment class which has the responsibility for tracking 
//both the name of the person who made the comment and the text of the comment.


}