// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
{
    Console.Clear();
    Console.WriteLine("Menu Options:");
    Console.WriteLine("  1. Start breathing activity");
    Console.WriteLine("  2. Start reflection activity");
    Console.WriteLine("  3. Start listing activity");
    Console.WriteLine("  4. Show activity log");
    Console.WriteLine("  5. Quit");
    Console.Write("Select a choice from the menu: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        new BreathingActivity().Run();
    }
    else if (choice == "2")
    {
        new ReflectionActivity().Run();
    }
    else if (choice == "3")
    {
        new ListingActivity().Run();
    }
    else if (choice == "4")
    {
        Console.Clear();
        Activity.DisplayActivityStats();
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
    else if (choice == "5")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice. Press Enter to try again.");
        Console.ReadLine();
    }
}

    }
}
