using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    public int Score { get; private set; } = 0;

    public void CreateGoal()
    {
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, desc, points);
                break;
            case "2":
                goal = new EternalGoal(name, desc, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, desc, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordGoalEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        Console.WriteLine("Select a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }

        Console.Write("Enter number: ");
        if (int.TryParse(Console.ReadLine(), out int index) &&
            index >= 1 && index <= _goals.Count)
        {
            int earned = _goals[index - 1].RecordEvent();
            AddScore(earned);
            Console.WriteLine($"You earned {earned} points!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {Score}");
    }

    public void AddScore(int points)
    {
        Score += points;
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine($"SCORE|{Score}");
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            if (line.StartsWith("SCORE|"))
            {
                Score = int.Parse(line.Split('|')[1]);
            }
            else if (line.StartsWith("SimpleGoal"))
            {
                _goals.Add(SimpleGoal.Deserialize(line));
            }
            else if (line.StartsWith("EternalGoal"))
            {
                _goals.Add(EternalGoal.Deserialize(line));
            }
            else if (line.StartsWith("ChecklistGoal"))
            {
                _goals.Add(ChecklistGoal.Deserialize(line));
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}
