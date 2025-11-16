class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string BookTitle, int ChapterNumber, int StartVerseNumber)
    {
        _book = BookTitle;
        _chapter = ChapterNumber;
        _startVerse = StartVerseNumber;
        _endVerse = StartVerseNumber;
    }

    public Reference(string BookTitle, int ChapterNumber, int StartVerseNumber, int EndVerseNumber)
    {
        _book = BookTitle;
        _chapter = ChapterNumber;
        _startVerse = StartVerseNumber;
        _endVerse = EndVerseNumber;
    }

    public string ReferencePrint()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }

    public bool Matches(string book, int chapter, int verse)
    {
        return _book.ToLower() == book.ToLower() && 
               _chapter == chapter && 
               _startVerse == verse;
    }
}