public class Cycling : Activity
{
    private double _speed;
    
    public Cycling(){}

    public void SetSpeed(double speed){
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * ( _lenght / 60);
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetActivityType()
    {
        return $"Cycling";
    }
}