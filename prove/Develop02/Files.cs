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


    public void addLineToFile(List<string> recordToSave)
        {
            foreach (string record in recordToSave)
            {
                using (StreamWriter outputFile = new StreamWriter(fileName, true))
                {
                    outputFile.WriteLine(record);
                }
            }
            
        }

    public void readFile()
    {
        using (StreamReader inputFile = new StreamReader(fileName))
        {   
            string line;
            while ((line = inputFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
        }
    }
}