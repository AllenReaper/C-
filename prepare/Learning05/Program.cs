using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        
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
