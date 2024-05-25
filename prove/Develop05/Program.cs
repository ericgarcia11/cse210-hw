using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(12.4,"Green"));
        shapes.Add(new Rectangle(9.76,10.47,"Yellow"));
        shapes.Add(new Circle(48.33,"Blue"));

        foreach(Shape shape in shapes){
            Console.WriteLine($"Color: {shape.GetColor()} -- Area: {shape.GetArea()}");
        }
    }
}