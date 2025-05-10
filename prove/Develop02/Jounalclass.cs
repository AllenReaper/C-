class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What kind of food did you have today?",
        "Did you get mad in trafic today?",
        "If you could have had a super power to use today what would it have been?",
        "Kick the Fat kid at KMart? or dont Kick the Fat kid at KMart?",
        "If you had the oportunity to get point for runing people over how many point would you have today?"
    };

    private Random random = new Random();

    public void WriteNewEntry()
    {
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        entries.Add(new Entry
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd"),
            Prompt = prompt,
            Response = response
        });

        Console.WriteLine("Entry added.\n");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.\n");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.Date);
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
                writer.WriteLine("-----");
            }
        }

        Console.WriteLine("Journal saved.\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string date = reader.ReadLine();
                string prompt = reader.ReadLine();
                string response = reader.ReadLine();
                reader.ReadLine(); // skip separator

                entries.Add(new Entry
                {
                    Date = date,
                    Prompt = prompt,
                    Response = response
                });
            }
        }

        Console.WriteLine("Journal loaded loaded up.\n");
    }
}