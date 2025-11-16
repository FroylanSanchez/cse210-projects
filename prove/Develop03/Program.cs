class Program
{
    static void Main()
    {
        Console.WriteLine("Loading scriptures...");
        List<Scripture> allScriptures = LoadAllScriptures("kjv.csv");
        
        Scripture chosen = FindScripture(allScriptures);
        RunMemorizer(chosen);
    }
    
    static List<Scripture> LoadAllScriptures(string filename)
    {
        List<Scripture> list = new List<Scripture>();
        string[] lines = File.ReadAllLines(filename);
        
        for (int i = 3; i < lines.Length; i++)
        {
            string line = lines[i];
            
            if (string.IsNullOrEmpty(line) || !char.IsDigit(line[0]))
            {
                continue;
            }
            
            int firstQuote = line.IndexOf('"');
            int lastQuote = line.LastIndexOf('"');
            
            if (firstQuote == -1 || lastQuote == -1)
            {
                continue;
            }
            
            string beforeText = line.Substring(0, firstQuote);
            string text = line.Substring(firstQuote + 1, lastQuote - firstQuote - 1);
            
            string[] parts = beforeText.Split(',');
            
            if (parts.Length < 5)
            {
                continue;
            }
            
            string book = parts[1];
            int chapter = int.Parse(parts[3]);
            int verse = int.Parse(parts[4]);
            
            text = text.Replace("¶", "").Trim();
            
            Reference reference = new Reference(book, chapter, verse);
            Scripture scripture = new Scripture(reference, text);
            list.Add(scripture);
        }
        
        Console.WriteLine($"Loaded {list.Count} scriptures");
        return list;
    }
    
    static Scripture FindScripture(List<Scripture> scriptures)
    {
        while (true)
        {
            Console.Write("Enter book: ");
            string book = Console.ReadLine();
            
            Console.Write("Enter chapter: ");
            int chapter = int.Parse(Console.ReadLine());
            
            Console.Write("Enter start verse: ");
            int startVerse = int.Parse(Console.ReadLine());
            
            Console.Write("Enter end verse (or same as start for single verse): ");
            int endVerse = int.Parse(Console.ReadLine());
            
            List<string> foundTexts = new List<string>();
            
            for (int verse = startVerse; verse <= endVerse; verse++)
            {
                foreach (Scripture s in scriptures)
                {
                    if (s.Matches(book, chapter, verse))
                    {
                        string rawText = GetRawScriptureText(s);
                        foundTexts.Add(rawText);
                        break;
                    }
                }
            }
            
            if (foundTexts.Count > 0)
            {
                string combinedText = string.Join(" ", foundTexts);
                
                Reference reference;
                if (startVerse == endVerse)
                    reference = new Reference(book, chapter, startVerse);
                else
                    reference = new Reference(book, chapter, startVerse, endVerse);
                    
                return new Scripture(reference, combinedText);
            }
            
            Console.WriteLine("Scripture not found. Please try again.\n");
        }
    }
    
    static string GetRawScriptureText(Scripture scripture)
    {
        string displayText = scripture.GetDisplayText();
        int firstSpace = displayText.IndexOf(' ');
        if (firstSpace >= 0)
        {
            string afterReference = displayText.Substring(firstSpace + 1);
            int colonIndex = afterReference.IndexOf(':');
            if (colonIndex >= 0)
            {
                int nextSpace = afterReference.IndexOf(' ', colonIndex);
                if (nextSpace >= 0)
                {
                    return afterReference.Substring(nextSpace + 1);
                }
            }
            return afterReference;
        }
        return displayText;
    }
    
    static void RunMemorizer(Scripture scripture)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("Good job memorizing!");
                break;
            }
            
            Console.WriteLine("\nPress Enter to hide words or type 'quit'");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit") break;
            
            scripture.HideRandomWords();
        }
    }
}