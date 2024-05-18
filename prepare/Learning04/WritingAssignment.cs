public class WritingAssignment : Assignment 
{
    private string _title;

    public WritingAssignment()
    {
        _title = "Unknown title";
    }

    public void setTitle(string title)
    {
        _title = title;
    }

    public string getTitle()
    {
        return _title;
    }

    public string GetWritingInformation(){
        return $"{getStudentName()} - {getTopic()}\n{_title} by {getStudentName()}";
    }
}