class Scripture
{
    private Reference _reference;
    private List<string> _words;

    public Scripture(string scriptureString, Reference referenceObject)
    {
        string[] scriptureArray = scriptureString.Split(' ');
        _words.AddRange(scriptureArray);    
        _reference = referenceObject;
    }

    public void HideRandomWords(int numberToHide )
    {

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