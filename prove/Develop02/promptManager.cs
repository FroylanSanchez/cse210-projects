using System;
using System.Collections.Generic;
using System.IO;

class PromptManager
{
    private static List<string> prompts = new List<string>();
    private static Random random = new Random();

    public static string GetRandomPrompt()
    {
        if (prompts.Count == 0)
        {
            string[] allLines = File.ReadAllLines("prompts.csv");
            foreach (string line in allLines)
            {
                prompts.Add(line);
            }
        }

        return prompts[random.Next(prompts.Count)];
    }
}