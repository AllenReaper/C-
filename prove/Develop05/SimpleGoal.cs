public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return (_isComplete ? "[X] " : "[ ] ") + Name;
    }

    public override string Serialize()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
    }

    public static SimpleGoal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
        goal._isComplete = bool.Parse(parts[4]);
        return goal;
    }
}
