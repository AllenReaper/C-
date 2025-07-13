public class Tag
{
    public string Name { get; set; }             // e.g., "Minifig", "Rare", "Technic"
    public string Description { get; set; }      // Optional: "Parts used in Technic builds"

    public Tag(string name, string description = "")
    {
        Name = name;
        Description = description;
    }

    public override string ToString()
    {
        return $"{Name} - {Description}";
    }
}
