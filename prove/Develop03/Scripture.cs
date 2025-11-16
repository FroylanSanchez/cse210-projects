class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.ReferencePrint() + " ";
        
        foreach (Word word in _words)
        {
            display += word.GetDisplay() + " ";
        }
        
        return display;
    }

    public void HideRandomWords()
    {
        int wordsToHide = 3;
        int wordsHidden = 0;
        
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        
        if (visibleWords.Count == 0) return;
        
        int wordsToActuallyHide = Math.Min(wordsToHide, visibleWords.Count);
        
        for (int i = 0; i < wordsToActuallyHide; i++)
        {
            int randomIndex = _random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public bool Matches(string book, int chapter, int verse)
    {
        return _reference.Matches(book, chapter, verse);
    }
}