public class Video {

//Your program should have a class for a Video that has the responsibility to track 
//the title, author, and length (in seconds) of the video. 
//Each video also has responsibility to store a list of comments, 
//and should have a method to return the number of comments. 


    private string _title;
    private string _author;
    private int _seconds;

    public void SetTitle(string title) {
        _title = title;
    }
    public void SetAuthor(string author) {
        _author = author;
    }

    public void SetSeconds(int seconds) {
        _seconds = seconds;
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

    public Video(string title, string author, int seconds) {
        
    }

    public int CommentCount(List<Comment> comments) {
        int count = 0;
        foreach (string comment in comments) {
            count += 1;
        }
    }


}