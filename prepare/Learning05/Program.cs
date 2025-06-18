using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test individual shapes
        Square square = new Square("Red", 5);
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        Console.WriteLine("\nList of shapes:");

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterate and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape - Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}
