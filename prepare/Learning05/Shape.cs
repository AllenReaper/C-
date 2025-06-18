using System;

public class Shape
{
    // Member variable
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getter
    public string GetColor()
    {
        return _color;
    }

    // Setter
    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method for area
    public virtual double GetArea()
    {
        return 0; // Default area
    }
}
