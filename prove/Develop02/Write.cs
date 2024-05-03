public class Write
{
     public string _answer;

     public string _promptAndNote;
     List<string> _writings = new List<string>();
     public Write()
    {
    }

    public List<string> AddPromptsToWritingsList()
    {
            _writings.Add(_promptAndNote);
            return _writings;
    }

    public void displayWritingList()
    {
        foreach (string record in _writings)
        {
            Console.WriteLine($"{record}\n");
        }
    }

    
}