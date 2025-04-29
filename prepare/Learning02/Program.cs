using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        double gradePercentage = Convert.ToDouble(Console.ReadLine());

        string letter;

        // Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        // Determine if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("nice, you passed");
        }
        else
        {
            Console.WriteLine("Do better next time");
        }
    }
    
}