public class Running : Activity
{
    private double _distance;

    public Running(){}

    public void SetDistance(double distance){
        _distance = distance;
    } 

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _lenght) * 60;
    }

    public override double GetPace()
    {
        return _lenght / _distance;
    }

    public override string GetActivityType()
    {
        return $"Running";
    }
}