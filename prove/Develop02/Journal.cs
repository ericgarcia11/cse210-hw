public class Journal
{
     List<string> _journal = new List<string>();
     public Journal()
    {
    }

    public List<string> AddEntriesToJournal(string entry)
    {
            _journal.Add(entry);
            return _journal;
    }

    public void displayEntries()
    {
        foreach (string entry in _journal)
        {
            Console.WriteLine($"{entry}\n");
        }
    }

    
}