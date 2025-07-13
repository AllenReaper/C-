public class StorageLocation
{
    public string Name { get; set; }             // e.g., "Drawer A3", "Bin 2", "Shelf 1"
    public string Description { get; set; }      // Optional: "Top drawer in white cabinet"

    public StorageLocation(string name, string description = "")
    {
        Name = name;
        Description = description;
    }

    public override string ToString()
    {
        return $"{Name} - {Description}";
    }
}
