public class Assignment 
{
    private string _studentName;
    private string _topic;

    public Assignment(){
        _studentName = "Anonymus";
        _topic = "Unknown topic";
    }

    public string getStudentName()
    {
        return _studentName;
    }

    public void setStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public void setTopic(string topic)
    {
        _topic = topic;
    }

    public string getTopic()
    {
        return _topic;
    }


    public string GetSummary(){
        return $"{_studentName} - {_topic}";
    }
}