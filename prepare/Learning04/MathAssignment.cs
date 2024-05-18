public class MathAssignment : Assignment 
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment()
    {
        _textbookSection = "Unknown section";
        _problems = "Unknown problem";
    }

    public void setTextbookSection(string section)
    {
        _textbookSection = section;
    }

    public string getTextbookSection()
    {
        return _textbookSection;
    }

    public void setProblems(string problems)
    {
        _problems = problems;
    }

    public string getProblems()
    {
        return _problems;
    }

    public string GetHomeworkList(){
        return $"Section {_textbookSection} Problems {_problems}";
    }
}