using System;

public class Square : Shape
{
    // Private member variable
    private double _side;

    // Constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override GetArea to return the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }
}
