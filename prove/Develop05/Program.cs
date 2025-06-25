using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("=== Goal Tracker ===");
            Console.WriteLine($"Current Score: {manager.Score}");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
                switch (choice)
                {
                    case 1: manager.CreateGoal(); break;
                    case 2: manager.ListGoals(); break;
                    case 3: manager.RecordGoalEvent(); break;
                    case 4: manager.DisplayScore(); break;
                    case 5: manager.SaveGoals(); break;
                    case 6: manager.LoadGoals(); break;
                    case 7: Console.WriteLine("Goodbye!"); break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            if (choice != 7)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }

        } while (choice != 7);
    }
}
