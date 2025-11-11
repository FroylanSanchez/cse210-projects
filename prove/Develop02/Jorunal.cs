using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddJournalEntry(string prompt, string response)
    {
        entries.Add(new JournalEntry(prompt, response));
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();
        foreach (var entry in entries)
        {
            lines.Add(entry.ToString());
        }
        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved to file.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        entries.Clear();
        foreach (var line in File.ReadLines(filename))
        {
            var parts = line.Split(',');
            if (parts.Length == 3)
                entries.Add(new JournalEntry(parts[1], parts[2]));
        }
        Console.WriteLine("Journal loaded from file.");
    }
}