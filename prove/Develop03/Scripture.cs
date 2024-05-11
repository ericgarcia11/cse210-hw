class Scripture
{
    private Reference _reference;
    private List<string> _words;

    private string _entireScripture;

    public Scripture(string scriptureString, Reference referenceObject)
    {
        _words = new List<string>();
        string[] scriptureArray = scriptureString.Split(' ');
        _words.AddRange(scriptureArray);    
        _reference = referenceObject;
        _entireScripture = scriptureString;
    }

    public void HideRandomWords(int numberToHide )
    {   _entireScripture = "";
        Random random = new Random();
        List<int> randomIndexes = new List<int>();
        while (randomIndexes.Count < numberToHide)
        {
            int randomIndex = random.Next(0, _words.Count);
            if (!randomIndexes.Contains(randomIndex))
            {
                randomIndexes.Add(randomIndex);
            }
        }
        int hidden = 0;
        for (int j = 0; j < _words.Count;j++)
        {   
            Word wordObject = new Word(_words[j]);
            string newWord = "";
            while (hidden < numberToHide)
            {
                if (randomIndexes[0] == j){
                    randomIndexes.RemoveAt(0);
                    hidden += 1;
                    wordObject.Hide();
                    newWord = wordObject.GetDisplayText();
                    _entireScripture += newWord + " ";
                    break;
                }else{
                    newWord = wordObject.GetDisplayText();
                    _entireScripture += newWord + " ";
                    break;
                }
            }
        }
        
    }

    public string GetDisplayText()
    {
        string referenceFormated = _reference.GetDisplayText() + " " + _entireScripture;
        return referenceFormated;
    }

    public bool IsCompletelyHidden()
    {   bool status = false;
        foreach (char i in _entireScripture){
            if (i != '_'){
                break;
            } else {
            status = true;
            }
        } 
                
        return status;
    }

}