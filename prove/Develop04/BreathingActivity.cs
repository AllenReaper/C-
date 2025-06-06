// BreathingActivity.cs
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        Activity.IncrementCount("Breathing");
        DisplayStartMessage();

        int timePerCycle = 6; // 3 seconds in, 3 seconds out
        int cycles = _duration / timePerCycle;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(3);
            Console.Write("Breathe out...");
            ShowCountdown(3);
        }

        DisplayEndMessage();

        
    
    }
}
