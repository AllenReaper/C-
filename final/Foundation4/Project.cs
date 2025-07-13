using System.Collections.Generic;

public class Project
{
    public string Name { get; set; }                        // e.g., "Custom Castle"
    public string Description { get; set; }                 // e.g., "Medieval-themed build using dark gray bricks"
    public List<LegoPart> RequiredParts { get; set; } = new();  // Parts needed for this project
    public List<Tag> Tags { get; set; } = new();            // e.g., "Castle", "Custom"
    public string Notes { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Description}";
    }
}
