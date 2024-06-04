public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(){

    }

    public void SetSpeaker(string speaker){
        _speaker = speaker;
    }

    public void SetCapacity(int capacity){
        _capacity = capacity;
    }

    public string GetSpeaker(){
        return _speaker;
    }

    public int GetCapacity(){
        return _capacity;
    }

    public string GetFullDetails(){
        return $" --- Lecture Event ---\n{GetStandartDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

}