public class ColorInfo
{
    public string Name { get; set; }              // e.g., "Red", "Trans-Blue"
    public int LegoColorId { get; set; }          // Optional LEGO color ID (used in BrickLink, etc.)
    public bool IsTranslucent { get; set; }       // True if it's a transparent/translucent color

    public ColorInfo(string name, int legoColorId = 0, bool isTranslucent = false)
    {
        Name = name;
        LegoColorId = legoColorId;
        IsTranslucent = isTranslucent;
    }

    public override string ToString()
    {
        return $"{Name} (ID: {LegoColorId}, Translucent: {IsTranslucent})";
    }
}
