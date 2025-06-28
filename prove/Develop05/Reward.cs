public class Reward
{
    public string Name { get; set; }
    public int Cost { get; set; }

    public Reward(string name, int cost)
    {
        Name = name;
        Cost = cost;
    }

    public string GetInfo()
    {
        return $"{Name} - {Cost} points";
    }

    public string Serialize()
    {
        return $"REWARD|{Name}|{Cost}";
    }

    public static Reward Deserialize(string data)
    {
        string[] parts = data.Split('|');
        return new Reward(parts[1], int.Parse(parts[2]));
    }
}
