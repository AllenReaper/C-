public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string Serialize();
}
