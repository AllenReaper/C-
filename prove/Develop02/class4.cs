/*class Journal   {


    public List<Entry> _entries = new List<Entry>(); // make entry list


    public void SaveFile()	// option for saving file(currently empty)
    {}


    public void LoadFile()	// option for loading file(currently empty)
    {}


    public void Display_Entries()
    {
        Console.WriteLine("Entries: \n");
        foreach (Entry entry in _entries)	// display all entries
            Console.WriteLine($"{entry}");	// in a list
    }
}




class Entry    {


    public string header()	// header, for naming the entry and having
    {					// it appear in the above entry list
        Console.Write("Enter Name, date, etc: ");
        String header = Console.ReadLine();
        return header;
    }


    public string body()	// where the text for the entry gets typed
    {
        Console.Write("Enter text for entry here: ");
        String body = Console.ReadLine();
        return body;
    }


    public void Display()	// put header and the body together
    {
        Console.WriteLine($"{header}\n");
        Console.WriteLine($"{body}\n");
    }
}
*/