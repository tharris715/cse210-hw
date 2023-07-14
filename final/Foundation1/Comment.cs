public class Comment {
    //set attributes
    public string _name;
    public string _text;
    //Comment constructor
    public Comment(string name, string text) {
        _name = name;
        _text = text;
    }

    //method to count comments
    public int CommentCount(List<Comment> comments) {
        int count = 0;
        foreach (Comment comment in comments) {
            count += 1;
        }
        return count;
    }
    //method to display comments
    public string DisplayComment(List<Comment> comments) {
        string com = "";
        int count = 1;
        foreach (Comment comment in comments) {
            com += $"\n{count}. {comment._name}: \"{comment._text}\" ";
            count += 1;
        }
        return com;
    }

}