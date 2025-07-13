using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    public List<LegoPart> Parts { get; set; } = new();
    public List<LegoSet> Sets { get; set; } = new();
    public List<Project> Projects { get; set; } = new();

    public void AddPart(LegoPart part) => Parts.Add(part);
    public void AddSet(LegoSet set) => Sets.Add(set);
    public void AddProject(Project project) => Projects.Add(project);

    public List<LegoPart> SearchByColor(string colorName) =>
        Parts.Where(p => p.Color != null && p.Color.Name.Equals(colorName, System.StringComparison.OrdinalIgnoreCase)).ToList();

    public List<LegoPart> SearchByCategory(string categoryName) =>
        Parts.Where(p => p.Category != null && p.Category.Name.Equals(categoryName, System.StringComparison.OrdinalIgnoreCase)).ToList();

    public LegoSet GetSetByNumber(string setNumber) =>
        Sets.FirstOrDefault(s => s.SetNumber.Equals(setNumber, System.StringComparison.OrdinalIgnoreCase));
}
