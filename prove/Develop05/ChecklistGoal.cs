public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
    {
        Name = name;
        Description = description;
        Points = points;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override int RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                return Points + BonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string checkbox = CurrentCount >= TargetCount ? "[X]" : "[ ]";
        return $"{checkbox} {Name} (Completed {CurrentCount}/{TargetCount})";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{TargetCount}|{CurrentCount}|{BonusPoints}";
    }

    public static ChecklistGoal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                     int.Parse(parts[4]), int.Parse(parts[6]));
        goal.CurrentCount = int.Parse(parts[5]);
        return goal;
    }
}
