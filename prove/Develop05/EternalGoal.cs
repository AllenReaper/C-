public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetStatus()
    {
        return $"[ ] {Name}";
    }

    public override string Serialize()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }

    public static EternalGoal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
}
