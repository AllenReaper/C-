// Activity.cs
using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.Write("\nEnter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }

    // Existing fields...
    protected static int _breathingCount = 0;
    protected static int _reflectionCount = 0;
    protected static int _listingCount = 0;

    // ... existing code ...

    public static void IncrementCount(string activityType)
    {
        switch (activityType)
        {
            case "Breathing": _breathingCount++; break;
            case "Reflection": _reflectionCount++; break;
            case "Listing": _listingCount++; break;
        }
    }

    public static void DisplayActivityStats()
    {
        Console.WriteLine("\nActivity Usage Log:");
        Console.WriteLine($"Breathing Activity:  {_breathingCount} time(s)");
        Console.WriteLine($"Reflection Activity: {_reflectionCount} time(s)");
        Console.WriteLine($"Listing Activity:    {_listingCount} time(s)");
    }
}
