using System;

class Program
{
    static void Main(string[] args)
    {
        // Base assignment
        Assignment baseAssignment = new Assignment("Jaxson", "coding");
        Console.WriteLine(baseAssignment.GetSummary());

        // Math assignment
        MathAssignment mathAssignment = new MathAssignment("Alexa McCammon", "Algebra", "3.8", "1-5");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Writing assignment
        WritingAssignment writingAssignment = new WritingAssignment("profesor Plaicton", "history Literature", "The Rise of planctonism");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
