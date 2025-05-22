using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Using the no-argument constructor
        Fraction frac1 = new Fraction();
        Console.WriteLine("fraction 1: " + frac1.GetFractionString());
        Console.WriteLine("decimal: " + frac1.GetDecimalValue());

        // Using the constructor with one argument
        Fraction frac2 = new Fraction(5);
        Console.WriteLine("Fraction 2: " + frac2.GetFractionString());
        Console.WriteLine("decimal: " + frac2.GetDecimalValue());

        // Using the constructor with two arguments
        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine("fraction 3: " + frac3.GetFractionString());
        Console.WriteLine("Decimal: " + frac3.GetDecimalValue());

        // Demonstrate setters and getters
        frac3.SetTop(1);
        frac3.SetBottom(3);
        Console.WriteLine("modified fraction 3: " + frac3.GetFractionString());
        Console.WriteLine("decimal: " + frac3.GetDecimalValue());

        Console.WriteLine($"top: {frac3.GetTop()}, Bottom: {frac3.GetBottom()}");

    }
}
