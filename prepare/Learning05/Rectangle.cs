public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public Rectangle(double lenght, double width, string color){
        _lenght = lenght;
        _width = width;
        SetColor(color);
    }


    public override double GetArea()
    {
        return _lenght * _width;
    }
}