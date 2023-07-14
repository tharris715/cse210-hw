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
    
    //method to combine all video and comment information to display to console.
    public void DisplayVideo() {
        Comment com = new Comment("","");
        Console.WriteLine($"\"{_title}\" created by {_author}. {_seconds} seconds long, # of comments: {com.CommentCount(_comments)} {com.DisplayComment(_comments)}");
    }

}