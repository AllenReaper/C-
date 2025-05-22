// Fraction.cs
using System;

public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Constructor with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter (numerator only)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with two parameters (numerator and denominator)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for Top
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int value)
    {
        _top = value;
    }

    // Getter and Setter for Bottom
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int value)
    {
        _bottom = value;
    }

    // Method to get fraction string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to get decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
