class Scripture
{
    private Reference _reference;
    private List<string> _words;

    public Scripture(string scriptureString, Reference referenceObject)
    {
        _words = new List<string>();
        string[] scriptureArray = scriptureString.Split(' ');
        _words.AddRange(scriptureArray);    
        _reference = referenceObject;
    }

    public void HideRandomWords(int numberToHide )
    {
        foreach (string elemento in _words)
        {
            Console.WriteLine(elemento);
        }
    }

    public string GetDisplayText()
    {
        string referenceFormated = _reference.GetDisplayText();
        return referenceFormated;
    }

    public bool IsCompletelyHidden()
    {   
        bool status = false;
        return status;
    }

}