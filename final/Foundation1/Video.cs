public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments;

    public Video(List<string> info){
        _title = info[0];
        _author = info[1];
        _length = info[2];
        _comments = new List<Comment>();
    }

    public void SetComments(Comment comment){
        _comments.Add(comment);
    }

    public int GetCommentsLenght(){
        return _comments.Count();
    }

    public void DisplayComments(){
        foreach(Comment comment in _comments){
            comment.DisplayCommentInfo();
        }
    }

    public void DisplayInfo(){
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length}\nTotal Comments: {_comments.Count()}");
    }
}