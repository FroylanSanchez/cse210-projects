using System;
using System.Collections.Generic;

class Grateful : BaseActivity
{
    private List<string> _prompts = new List<string>
    {
        "Think of something today that made you smile.",
        "Think of a person who has helped you recently.",
        "Think of a blessing you sometimes overlook.",
        "Think of something simple you are grateful for.",
        "Think of something in your life that brings you peace."
    };

    public Grateful() : base("Grateful Activity",
        "This activity helps you reflect on gratitude by listing things you are thankful for.")
    { }

    protected override void ExecuteActivity()
    {
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        Console.WriteLine("You have 5 seconds to think...");
        Countdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("Begin writing things you are grateful for:");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string entry = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(entry))
                    items.Add(entry);
            }
        }

        Console.WriteLine($"You listed {items.Count} things you are grateful for.");
    }
}
