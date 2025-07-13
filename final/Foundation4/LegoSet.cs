using System.Collections.Generic;

public class LegoSet
{
    public string SetNumber { get; set; }              // e.g., "21318"
    public string SetName { get; set; }                // e.g., "Tree House"
    public int Year { get; set; }                      // e.g., 2019
    public List<LegoPart> Parts { get; set; } = new(); // Parts included in this set
    public List<Tag> Tags { get; set; } = new();       // e.g., "Ideas", "Nature"

    public string Notes { get; set; }                  // Any extra notes about the set

    public override string ToString()
    {
        return $"{SetName} ({SetNumber}) - {Year}";
    }
}
