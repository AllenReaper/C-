using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        
        string response = "yes";
        while (response == "yes")
        {

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int gus = -1;
            
            
            while (gus != number)
            {
            Console.WriteLine("What is the magic number?");
            gus = int.Parse(Console.ReadLine());


                if (gus < number)
                {
                    Console.WriteLine("higher");
                }
                else if (gus > number)
                {
                    Console.WriteLine("lower");
                }
                else 
                {
                    Console.WriteLine("you are right");
                }
            }


            
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }

        
    
        List<int> numbers = new List<int>();
        int input;

        // Step 1: Collect numbers from the user until they enter 0
        Console.WriteLine("Enter numbers (enter 0 to stop):");
        while (true)
        {
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (input == 0)
                break;

            numbers.Add(input);
        }

        // Step 2: Compute and display results
        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine($"\nTotal: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Maximum: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
