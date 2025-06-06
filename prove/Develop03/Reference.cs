class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int? _verseEnd;

    public Reference(string reference)
    {
        int lastSpace = reference.LastIndexOf(' ');
        _book = reference.Substring(0, lastSpace);
        string[] chapterVerse = reference.Substring(lastSpace + 1).Split(':');
        _chapter = int.Parse(chapterVerse[0]);

        if (chapterVerse[1].Contains('-'))
        {
            string[] verses = chapterVerse[1].Split('-');
            _verseStart = int.Parse(verses[0]);
            _verseEnd = int.Parse(verses[1]);
        }
        else
        {
            _verseStart = int.Parse(chapterVerse[1]);
            _verseEnd = null;
        }
    }

    public override string ToString()
    {
        return _verseEnd.HasValue
            ? $"{_book} {_chapter}:{_verseStart}-{_verseEnd}"
            : $"{_book} {_chapter}:{_verseStart}";
    }
}