public class Swimming : Activity
{
    private double _nLaps;
    
    public Swimming(){}

    public void SetNLaps(double nLaps){
        _nLaps = nLaps;
    }

    public override double GetPace()
    {
        return (_nLaps * 50);
    }

    public override double GetDistance()
    {
        return _nLaps * 50 / 100;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _lenght) * 60;
    }

    public override string GetActivityType()
    {
        return $"Swimming";
    }
}