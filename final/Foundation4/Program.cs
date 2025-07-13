using System;

class Program
{
    static Inventory inventory = new Inventory();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("===== LEGO Inventory Menu =====");
            Console.WriteLine("1. View All Parts");
            Console.WriteLine("2. Add New Part");
            Console.WriteLine("3. Search Parts by Color");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ViewAllParts();
                    break;
                case "2":
                    AddNewPart();
                    break;
                case "3":
                    SearchPartsByColor();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }

    static void ViewAllParts()
    {
        Console.Clear();
        Console.WriteLine("===== All Parts =====");

        if (inventory.Parts.Count == 0)
        {
            Console.WriteLine("No parts in inventory.");
        }
        else
        {
            foreach (var part in inventory.Parts)
            {
                Console.WriteLine($"- {part.PartName} ({part.PartNumber}) - {part.Color?.Name}, Qty: {part.Quantity}");
            }
        }

        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }

    static void AddNewPart()
    {
        Console.Clear();
        Console.WriteLine("===== Add New Part =====");

        Console.Write("Part Name: ");
        string name = Console.ReadLine();

        Console.Write("Part Number: ");
        string number = Console.ReadLine();

        Console.Write("Color: ");
        string color = Console.ReadLine();

        Console.Write("Quantity: ");
        int quantity = int.TryParse(Console.ReadLine(), out int qty) ? qty : 1;

        var newPart = new LegoPart
        {
            PartName = name,
            PartNumber = number,
            Color = new ColorInfo(color),
            Quantity = quantity
        };

        inventory.AddPart(newPart);

        Console.WriteLine("Part added! Press Enter to return to the menu.");
        Console.ReadLine();
    }

        static void SearchPartsByColor()
    {
        Console.Clear();
        Console.WriteLine("===== Search by Color =====");

        Console.Write("Enter color name: ");
        string color = Console.ReadLine();

        var results = inventory.SearchByColor(color);

        if (results.Count == 0)
        {
            Console.WriteLine("No parts found in that color.");
        }
        else
        {
            foreach (var part in results)
            {
                Console.WriteLine($"- {part.PartName} ({part.PartNumber}), Qty: {part.Quantity}");
            }
        }

        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }


}