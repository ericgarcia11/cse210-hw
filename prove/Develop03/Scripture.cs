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
        Console.WriteLine($"\niniciando a hideRandomWords.");
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
            Console.WriteLine($"\nloop j, palavra: {_words[j]}.");
            Word wordObject = new Word(_words[j]);
            string newWord = "";
            while (hidden < numberToHide)
            {
                Console.WriteLine($"\n while no loop j,hidden = {hidden}, numberToHide = {numberToHide}.");
                if (randomIndexes[0] == j){
                    randomIndexes.RemoveAt(0);
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
        Console.WriteLine($"\nexecutada a hideRandomWords.");
        _entireScripture = string.Join(" ", _words);
    }

    public string GetDisplayText()
    {
        // _entireScripture = string.Join(" ", _words);
        string referenceFormated = _reference.GetDisplayText() + " " + _entireScripture;
        return referenceFormated;
    }

    public bool IsCompletelyHidden()
    {   bool status = true;
        // _entireScripture = string.Join(" ", _words);
        // foreach (char i in _entireScripture){
        //     if (i != '_'){
        //         break;
        //     } else {
        //     status = true;
        //     Console.WriteLine($"Deu true. Entire Scripure: {_entireScripture}\n");
        //     }
        // } 

        string[] wordsToCheck = _entireScripture.Split(' ');

        foreach (string character in wordsToCheck)
        {
            if (!character.Any(c => c == '_' || c == ' '))
            {
                status = false; 
                break;            
            }
        }     
        Console.WriteLine($"\nfuncao IsCompletelyHidden, status: {status}.");   
        return status;
    }

}