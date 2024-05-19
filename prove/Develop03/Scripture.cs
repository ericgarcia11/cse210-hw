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
        _entireScripture = string.Join(" ", _words);
    }

    public void HideRandomWords(int numberToHide )
    {    
        // this function was really hard. I took me about 8 hours to complete the entire code.
        int count = 0;
        foreach (string i in _words)
        {
            if (i.Any(c => c != '_'))
            {
                count++;
                if (count > 1)
                {
                    break;
                }
            }    
        }
        if (count <= 1){
                numberToHide = 1;
        }
        Random random = new Random();
        List<int> randomIndexes = new List<int>();
        while (randomIndexes.Count < numberToHide)
        {
            // create a random index
            int randomIndex = random.Next(0, _words.Count);
            // check if the provided index corresponds to a word already hidden. When is do not corresponds, it stop the while.
            while (_words[randomIndex].Contains("_")){
                randomIndex = random.Next(0, _words.Count);
            }
            // if the index already is on the indexes list, it is not added to indexes list. 
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
                if (randomIndexes.Contains(j)){
                    hidden += 1;
                    wordObject.Hide();
                    newWord = wordObject.GetDisplayText();
                    _words[j] = newWord;
                    break;
                }else{
                    newWord = wordObject.GetDisplayText();
                     _words[j] = newWord;
                    break;
                }
            }
        }
        _entireScripture = string.Join(" ", _words);
    }

    public string GetDisplayText()
    {
        string referenceFormated = _reference.GetDisplayText() + " " + _entireScripture;
        return referenceFormated;
    }

    public bool IsCompletelyHidden()
    {   bool status = true;
        string[] wordsToCheck = _entireScripture.Split(' ');

        foreach (string character in wordsToCheck)
        {
            if (!character.Any(c => c == '_' || c == ' '))
            {
                status = false; 
                break;            
            }
        }     
        return status;
    }

}