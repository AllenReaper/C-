using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a color:");
        Console.WriteLine("1 - Red");
        Console.WriteLine("2 - Green");
        Console.WriteLine("3 - Blue");

        Console.Write("Enter your choice (1, 2, or 3): ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You chose Red!");
                break;
            case "2":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You chose Green!");
                break;
            case "3":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You chose Blue!");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.ResetColor();


        Console.WriteLine("");

        





    }

}
