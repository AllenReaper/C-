using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


class Program
{
    static Inventory inventory = new Inventory();

    static void Main(string[] args)
    {
        bool running = true;
        LoadInventory();
        while (running)
        {
            Console.Clear();
            Console.WriteLine("===== LEGO Inventory Menu =====");
            Console.WriteLine("1. View All Parts");
            Console.WriteLine("2. Add New Part");
            Console.WriteLine("3. Search Parts by Color");
            Console.WriteLine("4. Exit");
            Console.WriteLine("===== LEGO Inventory Options =====");
            Console.WriteLine("5. Save Inventory");
            Console.WriteLine("6. Edit a Part");
            Console.WriteLine("7. Delete a Part");
            Console.WriteLine("8. View All Sets");
            Console.WriteLine("9. Add New Set");
            Console.WriteLine("10. View All Projects");
            Console.WriteLine("11. Add New Project");
            Console.WriteLine("===== LEGO Storage Options =====");
            Console.WriteLine("12. View Parts by Storage Location");
            Console.WriteLine("13. Manage Storage Locations");
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
                case "5":
                    SaveInventory();
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;
                case "6":
                    EditPart();
                    break;
                case "7":
                    DeletePart();
                    break;
                case "8":
                    ViewAllSets();
                    break;
                case "9":
                    AddNewSet();
                    break;
                case "10":
                    ViewAllProjects();
                    break;
                case "11":
                    AddNewProject();
                    break;
                case "12":
                    ViewPartsByStorageLocation();
                    break;
                case "13":
                    ManageStorageLocations();
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
        SaveInventory();
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

        Console.Write("Storage Location Name (e.g., 'Bin A1'): ");
        string locationName = Console.ReadLine();

        Console.Write("Location Description (optional): ");
        string locationDesc = Console.ReadLine();

        var location = new StorageLocation(locationName, locationDesc);

        var newPart = new LegoPart
        {
            PartName = name,
            PartNumber = number,
            Color = new ColorInfo(color),
            Quantity = quantity,
            //Category = new PartCategory(category),
            //Tags = tags,
            StorageLocation = location
        };

        if (inventory.Locations.Count > 0)
        {
            Console.WriteLine("\nAvailable Storage Locations:");
            for (int i = 0; i < inventory.Locations.Count; i++)
                Console.WriteLine($"{i + 1}. {inventory.Locations[i]}");

            Console.Write("Select a location by number (or leave blank for none): ");
            string locInput = Console.ReadLine();

            if (int.TryParse(locInput, out int locIndex) &&
                locIndex >= 1 && locIndex <= inventory.Locations.Count)
            {
                newPart.StorageLocation = inventory.Locations[locIndex - 1];
            }
        }

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

    static string dataFile = "inventory.json";

    static void SaveInventory()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            ReferenceHandler = ReferenceHandler.Preserve // handles circular references
        };

        string json = JsonSerializer.Serialize(inventory, options);
        File.WriteAllText(dataFile, json);
        Console.WriteLine("Inventory saved!");
    }

    static void LoadInventory()
    {
        if (File.Exists(dataFile))
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            string json = File.ReadAllText(dataFile);
            inventory = JsonSerializer.Deserialize<Inventory>(json, options) ?? new Inventory();
            Console.WriteLine("Inventory loaded!");
        }
        else
        {
            inventory = new Inventory(); // new if file not found
            Console.WriteLine("No saved inventory found. Starting fresh.");
        }
    }

    static void EditPart()
    {
        Console.Clear();
        Console.WriteLine("===== Edit Part =====");

        if (inventory.Parts.Count == 0)
        {
            Console.WriteLine("No parts available.");
            Console.ReadLine();
            return;
        }

        for (int i = 0; i < inventory.Parts.Count; i++)
        {
            var p = inventory.Parts[i];
            Console.WriteLine($"{i + 1}. {p.PartName} ({p.PartNumber}) - {p.Color?.Name}, Qty: {p.Quantity}");
        }

        Console.Write("Select a part number to edit: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= inventory.Parts.Count)
        {
            var part = inventory.Parts[index - 1];

            Console.Write($"New name (leave blank to keep '{part.PartName}'): ");
            string name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name)) part.PartName = name;

            Console.Write($"New color (leave blank to keep '{part.Color?.Name}'): ");
            string color = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(color)) part.Color = new ColorInfo(color);

            Console.Write($"New quantity (leave blank to keep {part.Quantity}): ");
            string qtyInput = Console.ReadLine();
            if (int.TryParse(qtyInput, out int newQty)) part.Quantity = newQty;

            Console.WriteLine("Part updated!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }

    static void DeletePart()
    {
        Console.Clear();
        Console.WriteLine("===== Delete Part =====");

        if (inventory.Parts.Count == 0)
        {
            Console.WriteLine("No parts available.");
            Console.ReadLine();
            return;
        }

        for (int i = 0; i < inventory.Parts.Count; i++)
        {
            var p = inventory.Parts[i];
            Console.WriteLine($"{i + 1}. {p.PartName} ({p.PartNumber}) - {p.Color?.Name}, Qty: {p.Quantity}");
        }

        Console.Write("Select a part number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= inventory.Parts.Count)
        {
            var part = inventory.Parts[index - 1];
            Console.WriteLine($"Are you sure you want to delete '{part.PartName}'? (y/n)");
            string confirm = Console.ReadLine();
            if (confirm.ToLower() == "y")
            {
                inventory.Parts.RemoveAt(index - 1);
                Console.WriteLine("Part deleted.");
            }
            else
            {
                Console.WriteLine("Cancelled.");
            }
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }

    static void ViewAllSets()
    {
        Console.Clear();
        Console.WriteLine("===== All LEGO Sets =====");

        if (inventory.Sets.Count == 0)
        {
            Console.WriteLine("No sets in inventory.");
        }
        else
        {
            foreach (var set in inventory.Sets)
            {
                Console.WriteLine($"- {set.SetName} ({set.SetNumber}), Year: {set.Year}");
            }
        }

        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }

    static void AddNewSet()
    {
        Console.Clear();
        Console.WriteLine("===== Add New LEGO Set =====");

        Console.Write("Set Name: ");
        string name = Console.ReadLine();

        Console.Write("Set Number: ");
        string number = Console.ReadLine();

        Console.Write("Year (optional): ");
        int year = int.TryParse(Console.ReadLine(), out int y) ? y : 0;

        var newSet = new LegoSet
        {
            SetName = name,
            SetNumber = number,
            Year = year
        };

        inventory.AddSet(newSet);

        Console.WriteLine("Set added! Press Enter to return to the menu.");
        Console.ReadLine();
    }

    static void ViewAllProjects()
    {
        Console.Clear();
        Console.WriteLine("===== All Projects =====");

        if (inventory.Projects.Count == 0)
        {
            Console.WriteLine("No projects created yet.");
        }
        else
        {
            foreach (var project in inventory.Projects)
            {
                Console.WriteLine($"- {project.Name}: {project.Description}");
            }
        }

        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }

    static void AddNewProject()
    {
        Console.Clear();
        Console.WriteLine("===== Add New Project =====");

        Console.Write("Project Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        var newProject = new Project
        {
            Name = name,
            Description = desc
        };

        inventory.AddProject(newProject);

        Console.WriteLine("Project added! Press Enter to return to the menu.");
        Console.ReadLine();
    }

    static void ViewPartsByStorageLocation()
    {
        Console.Clear();
        Console.WriteLine("===== Parts by Storage Location =====");

        var grouped = inventory.Parts
            .GroupBy(p => p.StorageLocation?.Name ?? "Unassigned")
            .OrderBy(g => g.Key);

        foreach (var group in grouped)
        {
            Console.WriteLine($"\n--- Location: {group.Key} ---");
            foreach (var part in group)
            {
                Console.WriteLine($"- {part.PartName} ({part.PartNumber}) x{part.Quantity} [{part.Color?.Name}]");
            }
        }

        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }

    static void ManageStorageLocations()
    {
        bool managing = true;

        while (managing)
        {
            Console.Clear();
            Console.WriteLine("===== Manage Storage Locations =====");
            Console.WriteLine("1. View All Locations");
            Console.WriteLine("2. Add New Location");
            Console.WriteLine("3. Edit Location");
            Console.WriteLine("4. Delete Location");
            Console.WriteLine("5. Back to Main Menu");

            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ViewAllLocations();
                    break;
                case "2":
                    AddNewLocation();
                    break;
                case "3":
                    EditLocation();
                    break;
                case "4":
                    DeleteLocation();
                    break;
                case "5":
                    managing = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }

        static void ViewAllLocations()
        {
            Console.Clear();
            Console.WriteLine("===== Storage Locations =====");

            if (inventory.Locations.Count == 0)
                Console.WriteLine("No locations found.");
            else
                for (int i = 0; i < inventory.Locations.Count; i++)
                    Console.WriteLine($"{i + 1}. {inventory.Locations[i]}");

            Console.WriteLine("\nPress Enter to continue.");
            Console.ReadLine();
        }

        static void AddNewLocation()
        {
            Console.Clear();
            Console.WriteLine("===== Add New Location =====");

            Console.Write("Location Name: ");
            string name = Console.ReadLine();

            Console.Write("Description (optional): ");
            string desc = Console.ReadLine();

            inventory.Locations.Add(new StorageLocation(name, desc));

            Console.WriteLine("Location added! Press Enter to continue.");
            Console.ReadLine();
        }

        static void EditLocation()
        {
            ViewAllLocations();

            Console.Write("Enter location number to edit: ");
            if (int.TryParse(Console.ReadLine(), out int index) &&
                index >= 1 && index <= inventory.Locations.Count)
            {
                var loc = inventory.Locations[index - 1];

                Console.Write($"New Name (leave blank to keep '{loc.Name}'): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName)) loc.Name = newName;

                Console.Write($"New Description (leave blank to keep): ");
                string newDesc = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newDesc)) loc.Description = newDesc;

                Console.WriteLine("Location updated.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        static void DeleteLocation()
        {
            ViewAllLocations();

            Console.Write("Enter location number to delete: ");
            if (int.TryParse(Console.ReadLine(), out int index) &&
                index >= 1 && index <= inventory.Locations.Count)
            {
                var loc = inventory.Locations[index - 1];

                // Check if it's in use by a part
                if (inventory.Parts.Any(p => p.StorageLocation?.Name == loc.Name))
                {
                    Console.WriteLine("This location is in use by one or more parts. Cannot delete.");
                }
                else
                {
                    inventory.Locations.RemoveAt(index - 1);
                    Console.WriteLine("Location deleted.");
                }
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }






    }
}