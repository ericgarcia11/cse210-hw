public class Receptions : Event
{
    private string _emailForRSVP;

    public Receptions(){}

    public void SetEmailForRSVP(string email){
        _emailForRSVP = email;
    }

    public string GetEmailForRSVP(){
        return _emailForRSVP;
    }

    public string GetFullDetails(){
        return $" --- Reception Event ---\n{GetStandartDetails()}\nEmail for RSVP: {_emailForRSVP}";
    }

}