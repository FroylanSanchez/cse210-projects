using System;

class JournalEntry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }

    public JournalEntry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}