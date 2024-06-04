public class OutdookGatherings : Event
{
    private string _weather;

    public OutdookGatherings(){

    }

    public void SetWeather(string weather){
        _weather = weather;
    }

    public string GetWeather(){
        return _weather;
    }

    public string GetFullDetails(){
        return $" --- Outdoor Gathering Event ---\n{GetStandartDetails()}\nWeather Forecast: {_weather}";
    }

}