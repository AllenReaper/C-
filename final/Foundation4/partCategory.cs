public class PartCategory
{
    public string Name { get; set; }            // e.g., "Brick", "Technic", "Tile"
    public string Description { get; set; }     // Optional description for the category

    public PartCategory(string name, string description = "")
    {
        Name = name;
        Description = description;
    }

    public override string ToString()
    {
        return $"{Name} - {Description}";
    }
}
