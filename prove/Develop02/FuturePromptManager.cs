using System;
using System.Collections.Generic;
using System.IO;

class FuturePromptManager
{
    private static List<string> futurePrompts = new List<string>();
    private static Random random = new Random();

    public static string GetRandomFuturePrompt()
    {
        if (futurePrompts.Count == 0)
        {
            string[] allLines = File.ReadAllLines("future_prompts.csv");
            foreach (string line in allLines)
            {
                futurePrompts.Add(line);
            }
        }

        return futurePrompts[random.Next(futurePrompts.Count)];
    }
}