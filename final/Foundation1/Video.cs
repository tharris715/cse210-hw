public class Video {

//Your program should have a class for a Video that has the responsibility to track 
//the title, author, and length (in seconds) of the video. 
//Each video also has responsibility to store a list of comments, 
//and should have a method to return the number of comments. 


    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments;

    public void SetTitle(string title) {
        _title = title;
    }
    public void SetAuthor(string author) {
        _author = author;
    }

    public void SetSeconds(int seconds) {
        _seconds = seconds;
    }
    public void SetComments(List<Comment> comments) {
        _comments = comments;
    }

    public string GetTitle() {
        return _title;
    }
    public string GetAuthor() {
        return _author;
    }
    public int GetSeconds() {
        return _seconds;
    }
    public List<Comment> GetComments() {
        return _comments;
    }

    public Video(string title, string author, int seconds, List<Comment> comments) {
        _title = title;
        _author = author;
        _seconds = seconds;
        _comments = comments;
    }

    public int CommentCount(List<Comment> comments) {
        int count = 0;
        foreach (Comment comment in comments) {
            count += 1;
        }
        return count;
    }

    public string DisplayComment(List<Comment> comments) {
        foreach (Comment comment in comments) {
            string com = comment._name + ": " + comment._text;
            return com;
        }
        return "";
           

    }

    public void DisplayVideo() {
        Console.WriteLine($"\"{GetTitle()}\", {GetAuthor()}, {GetSeconds()} seconds long, # of comments: {CommentCount(GetComments())}, {DisplayComment(GetComments())}");
    }

}