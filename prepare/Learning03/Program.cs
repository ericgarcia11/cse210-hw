using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        string fractionStr1 = fraction1.GetFractionString();
        Console.WriteLine(fractionStr1);
        double fractionDec1 = fraction1.GetDecimalValue();
        Console.WriteLine(fractionDec1);
        Fraction fraction2 = new Fraction(5);
        string fractionStr2 = fraction2.GetFractionString();
        Console.WriteLine(fractionStr2);
        double fractionDec2 = fraction2.GetDecimalValue();
        Console.WriteLine(fractionDec2);
        Fraction fraction3 = new Fraction(3,4);
        string fractionStr3 = fraction3.GetFractionString();
        Console.WriteLine(fractionStr3);
        double fractionDec3 = fraction3.GetDecimalValue();
        Console.WriteLine(fractionDec3);
    }
}

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction (){
        _top = 1;
        _bottom = 1;
    }

    public Fraction (int numerator){
        _top = numerator;
        _bottom = 1;
    }

    public Fraction (int numerator, int denominator){
        _top = numerator;
        _bottom = denominator;
    }

     public int GetNumerator()
    {
        return _top;
    }

    public int GetDenominator()
    {
        return _bottom;
    }

    public void SetNumerator(int numerator)
    {
        _top = numerator;
    }

    public void SetNumeratorAndDenominator(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public string GetFractionString()
    {
        string fractionString = ($"{_top}/{_bottom}");
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double dividing = _top / _bottom; 
        return dividing;
    }
}