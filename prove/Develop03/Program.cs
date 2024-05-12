using System;
using System.Security.Cryptography.X509Certificates;
// In order to claim extra points, I added a code part to get scriptures and references from two differents list, 
// which can receive as many scriptures we want to run the program.
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
        string response = "";
        string[] referenceArray = reference.Split(',');
        Reference referenceObject = getReferenceObject(referenceArray);
        Scripture scriptureObject = new Scripture(scripture,referenceObject);
        int wordsToHide = 2;
        while (response != "quit"){
            Console.Clear();
            string displayScripture = scriptureObject.GetDisplayText();
            Console.WriteLine($"{displayScripture}");
            if (!scriptureObject.IsCompletelyHidden()){
                scriptureObject.HideRandomWords(wordsToHide);
            }else{
                break;
            }
            response = Console.ReadLine();
        }
    }

    public static Reference getReferenceObject(string[] referenceArray){
            int howManyVerses = referenceArray.Length;
            if (howManyVerses == 3)
            {
                Reference nweReferenceObject = new Reference(referenceArray[0], int.Parse(referenceArray[1]), int.Parse(referenceArray[2]));
                return nweReferenceObject;
            }else{
                Reference nweReferenceObject = new Reference(referenceArray[0], int.Parse(referenceArray[1]), int.Parse(referenceArray[2]), int.Parse(referenceArray[3]));
                return nweReferenceObject;
        }}
}