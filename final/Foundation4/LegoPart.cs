using System.Collections.Generic;

public class LegoPart
{
    public string PartNumber { get; set; }         // Official LEGO part ID
    public string PartName { get; set; }           // e.g., "1x2 Brick"
    public PartCategory Category { get; set; }     // Reference to a category object
    public string Subcategory { get; set; }        // e.g., "1x2", "2x4"
    public ColorInfo Color { get; set; }           // Reference to a color object
    public int Quantity { get; set; }              // How many of this part
    public StorageLocation Location { get; set; }  // Physical location
    public List<Tag> Tags { get; set; } = new();   // Tags like “Minifig”, “Rare”
    public string Notes { get; set; }              // Any extra notes
}
