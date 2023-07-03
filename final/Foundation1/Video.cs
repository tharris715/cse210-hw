public class Video {

    //set attributes
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments;

    //video constructor utilizing above attributes
    public Video(string title, string author, int seconds, List<Comment> comments) {
        _title = title;
        _author = author;
        _seconds = seconds;
        _comments = comments;
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
        foreach (Comment comment in comments) {
            com += $"{comment._name}: \"{comment._text}\" ";
        }
        return com;
    }
    //method to combine all video and comment information to display to console.
    public void DisplayVideo() {

        Console.WriteLine($"\"{_title}\", {_author}, {_seconds} seconds long, # of comments: {CommentCount(_comments)}, {DisplayComment(_comments)}");
    }

}