using System;

class Breathing : BaseActivity
{
    public Breathing() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    protected override void ExecuteActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            Countdown(4);

            if (DateTime.Now >= endTime)
                break;

            Console.Write("Now breathe out...");
            Countdown(4);
        }
    }
}
