public class WritingAssignment : Assignment
{
    // Writing-specific member variables
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to return writing information
    public string GetWritingInformation()
    {
        return $"{GetStudentName()} - \"{_title}\"";
    }
}
