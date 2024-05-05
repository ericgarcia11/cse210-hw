using System.IO;
using System;
using System.Collections.Generic;

public class Files
{
    public string fileName;

    public string recordToSave;

    public Files(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("");
        }
    }

    public void addJournalToFile(Journal journal)
        {
                using (StreamWriter outputFile = new StreamWriter(fileName, true))
                {
                    List<string> entries = journal.returnJournal();
                    foreach (string entry in entries)
                    {
                        outputFile.WriteLine(entry);
                    }
                }    
        }
    public void addLineToFile(string recordToSave)
        {
                using (StreamWriter outputFile = new StreamWriter(fileName, true))
                {
                    outputFile.WriteLine(recordToSave);
                }    
        }
}