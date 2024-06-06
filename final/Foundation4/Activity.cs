public class Activity
{
    protected string _date;
    protected double _lenght;
    public Activity(){}

    public void SetDate(string date){
        _date = date;
    }

    public void SetLenght(double lenght){
        _lenght = lenght;
    }

    public virtual double GetDistance(){
        return .0;
    }

    public virtual double GetSpeed(){
        return .0;
    }

    public virtual double GetPace()
    {
        return .0;
    }

    public virtual string GetSummary(){
        return $"{_date} {GetActivityType()} ({_lenght} min): Distance {GetDistance()} km, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km";
    } 

    public virtual string GetActivityType(){
        return "";
    }

}