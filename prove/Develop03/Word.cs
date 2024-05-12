class Word
{
    private string  _text;
    private bool _isHidden = false;


    public Word(string word){
        _text = word;
    }

    public void Hide()
    {
        // Console.WriteLine($"\nfuncao hide, class Word, escondendo a palavra: {_text}.");
        int wordLenght = _text.Length;
        string hidenCharactere = "_";
        string newWord = "";
        for (int i = 0; i < wordLenght; i++)
        {
            newWord += hidenCharactere;
        }
        _text = newWord;
        _isHidden = true;
    }

      public string GetDisplayText()
    {
        return _text;
    }


    public bool IsHidden()
    {
        return _isHidden;
    }
}