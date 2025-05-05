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

        // Call the functions in order
    
            DisplayWelcome();

            string userName = PromptUserName();
            int favoriteNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(favoriteNumber);

            DisplayResult(userName, squaredNumber);
        

        // Function to display a welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

            // Function to prompt for and return the user's name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        // Function to prompt for and return the user's favorite number
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter an integer: ");
            }
            return number;
        }

        // Function to square a number
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // Function to display the result
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
        }
    
    
    
    
    
    
    
    }
    
}