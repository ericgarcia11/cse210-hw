using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<string> scriptures = new List<string>
        {
            "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.",
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
            "And I said unto him: I know not.",
            "And Shez was the son of Heth.And Heth was the son of Com. And Com was the son of Coriantum.",
            "Let thy bowels also be full of charity towards all men, and to the household of faith, and let virtue garnish thy thoughts unceasingly; then shall thy confidence wax strong in the presence of God; and the doctrine of the priesthood shall distil upon thy soul as the dews from heaven."
        };
        List<string> references = new List<string>
        {
            "Mosiah,3,19",
            "1 Nephi,3,7",
            "1 Nephi,13,22",
            "Ether,1,25,27",
            "D&C,121,45"
        };
        int randomIndex = random.Next(0,scriptures.Count);
        string scripture = scriptures[randomIndex];
        string reference = references[randomIndex];
        Console.Clear();
        Console.WriteLine($"{reference}: {scripture}");
    }
}

class Scripture
{
    private string _reference;
    private List<string> _words;

    public void HideRandomWords(int numberToHide )
    {

    }

    public string GetDisplayText()
    {
        string text = "";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}

class _reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public void Hide()
    {

    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        string text = "";
        return text;
    }

}

class Word
{
    private string  _text;
    private bool _isHidden;

    public string GetDisplayText()
    {
        string text = "";
        return text;
    }
}