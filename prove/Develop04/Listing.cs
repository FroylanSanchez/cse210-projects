using System;
using System.Collections.Generic;

class Listing : BaseActivity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    protected override void ExecuteActivity()
    {
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("You have 5 seconds to think...");
        Countdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("Start listing items:");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string entry = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(entry))
                    items.Add(entry);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}
