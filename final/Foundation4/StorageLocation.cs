public class StorageLocation
{
    public string Name { get; set; }
    public string Description { get; set; }

    public StorageLocation() { }

    public StorageLocation(string name, string description = "")
    {
        Name = name;
        Description = description;
    }

    public override string ToString()
    {
        return $"{Name}" + (string.IsNullOrWhiteSpace(Description) ? "" : $" - {Description}");
    }
}
