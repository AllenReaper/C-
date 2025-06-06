public class MathAssignment : Assignment
{
    // Private member variables specific to MathAssignment
    private string _textbookSection;
    private string _problems;

    // Constructor that calls the base constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic) // call base class constructor
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to get the homework list
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
