class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary(string filePath)
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        LoadFromFile(filePath);
    }

    private void LoadFromFile(string filePath)
    {
        foreach (string line in File.ReadLines(filePath))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 2)
            {
                Reference reference = new Reference(parts[0].Trim());
                string text = parts[1].Trim();
                _scriptures.Add(new Scripture(reference, text));
            }
        }
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}